using System;
using System.Text.Json;

namespace Learn
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Person person = new Person();
			person.IsAlive = false;
			person.Name = "Test";
			using (Stream s = new FileStream(@"1.txt",FileMode.OpenOrCreate))
			{
				if (s.Length != 0)
					return;
				byte[] p = JsonSerializer.SerializeToUtf8Bytes(person);
				s.Write(p);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (Stream s = new FileStream(@"1.txt", FileMode.Open))
			{
				var p = JsonSerializer.Deserialize<Person>(s);
				textBox1.Text = p.Name;
				(p.IsAlive ? radioButton1 : radioButton2).Checked = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (Stream s = new FileStream(@"1.txt", FileMode.OpenOrCreate))
			{
				if (textBox1.Text == "")
					return;
				var p = JsonSerializer.SerializeToUtf8Bytes(new Person() { IsAlive= (radioButton1.Checked) ? true : false, Name = textBox1.Text });
				s.Write(p);
			}
		}
	}
}
