using System.Text;

namespace Learn
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (Stream from = new FileStream(textBox1.Text, FileMode.Open), to = new FileStream(textBox2.Text, FileMode.Create))
			{
				try
				{

					int c = from.ReadByte();
					while (c != -1)
					{
						to.WriteByte((byte)c);
						c = from.ReadByte();
					}
				}
				catch (FileNotFoundException ex)
				{
					Console.WriteLine("File {0} not found: ", ex.FileName);
					throw;
				}

			}
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
