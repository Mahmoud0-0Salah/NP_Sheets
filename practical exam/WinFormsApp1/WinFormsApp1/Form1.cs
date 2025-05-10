using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
#pragma warning disable SYSLIB0011;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		TcpClient client = new TcpClient();
		NetworkStream ns;

		public Form1()
		{
			InitializeComponent();
			client.Connect(IPAddress.Loopback.ToString(), 1234);
			ns = client.GetStream();

			XmlSerializer bf = new XmlSerializer(typeof(Person));
			byte[] data;
			using (MemoryStream ms = new MemoryStream())
			{
				var pe = new Person() { id = 1111111, name = "Your name" };
				bf.Serialize(ms, pe);
				data = ms.ToArray();
			}

			var le = BitConverter.GetBytes(data.Length);
			ns.Write(le, 0, le.Length);
			ns.Write(data, 0, data.Length);
			ns.Flush();
			le = new byte[4];
			ns.Read(le, 0, le.Length);
			data = new byte[BitConverter.ToInt32(le)];
			ns.Read(data, 0, data.Length);
			Res r;
			using (MemoryStream ms = new MemoryStream(data))
			{
				bf = new XmlSerializer(typeof(Res));
				r = (Res)bf.Deserialize(ms);
			}
			richTextBox1.Text = r.res;

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var file = File.ReadAllBytes("File Path");
			var le = BitConverter.GetBytes(file.Length);
			ns.Write(le, 0, le.Length);
			ns.Write(file, 0, file.Length);

			le = new byte[4];
			ns.Read(le, 0, le.Length);
			var data = new byte[BitConverter.ToInt32(le)];
			ns.Read(data, 0, data.Length);
			XmlSerializer bf = new XmlSerializer(typeof(Res));
			Res r;
			using (MemoryStream ms = new MemoryStream(data))
			{
				bf = new XmlSerializer(typeof(Res));
				r = (Res)bf.Deserialize(ms);
			}
			richTextBox1.Text = r.res;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ns.Write(new byte[1], 0, 1);
			var le = new byte[4];
			ns.Read(le, 0, le.Length);
			var data = new byte[BitConverter.ToInt32(le)];
			int total = 0;
			while (total < data.Length)
			{
				int r = ns.Read(data, total, data.Length - total);
				if (r == 0) break;
				total += r;
			}
			File.WriteAllBytes("File Path", data);
			pictureBox1.Image = Image.FromFile("File Path");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
