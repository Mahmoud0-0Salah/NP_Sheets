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
			string filePath = textBox1.Text;

			try
			{
				using (TextReader fileStream = new StreamReader(filePath))
				{
					Dictionary<string, int> mp = new();
					string l = fileStream.ReadLine();
					while (l != null)
					{
						mp[l] = mp.ContainsKey(l) ? mp[l] + 1 : 1;
						l = fileStream.ReadLine();
					}
					foreach (var item in mp.OrderBy(mp => mp.Key))
					{
						richTextBox1.Text += $"{item.Key} - {item.Value}\n";
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
	
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}
	}
}
