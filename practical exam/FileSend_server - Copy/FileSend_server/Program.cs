using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

//------------------protocol----------------
//send length of  Serialized person obj
//send  Serialized person obj
//read length of  Serialized res obj
//read  Serialized res obj
//send length of  file
//send  file
//read length of  Serialized res obj
//read  Serialized res obj
//send one byte to start read file from server (Simulate that the file has been processed)
//read length of  file
//read  file

namespace FileSend_server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener se = new TcpListener(IPAddress.Any, 1234);
            se.Start();
			Console.WriteLine("Server started, waiting for connection...");
			TcpClient client = se.AcceptTcpClient();
			NetworkStream ns = client.GetStream();
            byte[] le = new byte[4];
            ns.Read(le, 0, le.Length);
			byte[] data = new byte[BitConverter.ToInt32(le)];
			XmlSerializer bf = new XmlSerializer(typeof(Person));
			ns.Read(data,0, data.Length);
			Person p;
			using (MemoryStream ms = new MemoryStream(data))
			{
				p = (Person)bf.Deserialize(ms);
			}

			var res = new Res();
			res.res = $"Your data sended successfully\nyour name is {p.name}\nid = {p.id}";
			using (MemoryStream ms = new MemoryStream())
			{
				bf = new XmlSerializer(typeof(Res));
				bf.Serialize(ms, res);
				data = ms.ToArray();
			}
			le = BitConverter.GetBytes(data.Length);
			ns.Write(le, 0, le.Length);
			ns.Write(data, 0, data.Length);



			le = new byte[4];
			ns.Read(le, 0, le.Length);
			data = new byte[BitConverter.ToInt32(le)];
			int total = 0;
			var file = data;
			while (total < data.Length)
			{
				int read = ns.Read(data, total, data.Length - total);
				if (read == 0) break;
				total += read;
			}
			res.res = $"Your file sended successfully with size = {total}";
			using (MemoryStream ms = new MemoryStream())
			{
				bf.Serialize(ms, res);
				data = ms.ToArray();
			}
			le = BitConverter.GetBytes(data.Length);
			ns.Write(le, 0, le.Length);
			ns.Write(data, 0, data.Length);

			
			
			ns.Read(new byte[1], 0, 1);
			le = BitConverter.GetBytes(file.Length);
			ns.Write(le, 0, le.Length);
			ns.Write(file, 0, file.Length);

		}
	}
}
