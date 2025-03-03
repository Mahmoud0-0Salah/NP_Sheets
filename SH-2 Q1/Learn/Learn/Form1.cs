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
			using (Stream s = new FileStream(textBox1.Text, FileMode.Create))
			{
				foreach (var c in textBox2.Text)
				{
					s.WriteByte((byte)c);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (Stream s = new FileStream(textBox1.Text, FileMode.Open))
			{
				try
				{

					StringBuilder stringBuilder = new StringBuilder();
					int c = s.ReadByte();
					while (c != -1)
					{
						stringBuilder.Append((char)c);
						c = s.ReadByte();
					}
					richTextBox2.Text = stringBuilder.ToString();
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
			foreach (var control in Controls)
			{
				if (control is TextBox)
					((TextBox)control).Text = "";

				else if (control is RichTextBox)
					((RichTextBox)control).Text = "";
			}
		}
	}
}
