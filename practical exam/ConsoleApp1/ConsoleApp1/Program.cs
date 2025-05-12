using FileSend_server;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TcpClient clinet = new TcpClient();
			clinet.Connect(IPAddress.Loopback, 1234);
			var ns = clinet.GetStream();
			var person = new Person() { id = 11111111, name = "Your name" };
			byte[] data;
			byte[] le;
			XmlSerializer Pserializer = new XmlSerializer(typeof(Person));
			XmlSerializer Rserializer = new XmlSerializer(typeof(Res));
			using (MemoryStream ms = new MemoryStream())
			{
				Pserializer.Serialize(ms, person);
				data = ms.ToArray();
			}
			le = BitConverter.GetBytes(data.Length);
			ns.Write(le, 0, le.Length);
			ns.Write(data, 0, data.Length);
			ns.Read(le, 0, le.Length);
			data = new byte[BitConverter.ToInt32(le)];
			ns.Read(data, 0, data.Length);
			
			using (MemoryStream ms = new MemoryStream(data))
			{
				Res res = (Res)Rserializer.Deserialize(ms);
				Console.WriteLine(res.res);
			}
			data = File.ReadAllBytes("Your Path");
			le = BitConverter.GetBytes(data.Length);
			ns.Write(le,0,le.Length);
			ns.Write(data,0,data.Length);
			le = new byte[4];
			ns.Read(le,0,le.Length);
			data = new byte[BitConverter.ToInt32(le)];
			ns.Read(data,0,data.Length);
			using (MemoryStream ms = new MemoryStream(data))
			{
				Res res = (Res)Rserializer.Deserialize(ms);
				Console.WriteLine(res.res);
			}
			ns.Write(new byte[1],0,1);

			ns.Read(le,0,le.Length);
			int length = BitConverter.ToInt32(le);
			data = new byte[length];

			int total = 0;
			while (total < length)
			{
				int r = ns.Read(data,total,data.Length-total);
				if (r == 0) break;
				total += r;
			}
			using (MemoryStream ms = new MemoryStream(data))
			using (GZipStream zip = new GZipStream(ms,CompressionMode.Decompress))
			using (FileStream fs = new FileStream("Your Path", FileMode.Create))
			{
				zip.CopyTo(fs);
			}
		}

	}
}
