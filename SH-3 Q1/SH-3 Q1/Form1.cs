using System.Net.Sockets;
using System.Net;

namespace SH_3_Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int recv;
			byte[] data = new byte[1024];
			IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
			Socket newsock = new Socket(AddressFamily.InterNetwork,
			SocketType.Stream, ProtocolType.Tcp);
			newsock.Bind(ipep);
			newsock.Listen(10);
			Thread thread = new Thread(() => WriteINRichBox("Waiting for a client..."));
			thread.Start();
		}
		void WriteINRichBox(string x)
		{
			richTextBox1.AppendText(x);
		}
	}
}
