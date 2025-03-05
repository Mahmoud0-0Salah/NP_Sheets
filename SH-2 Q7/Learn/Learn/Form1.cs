using System.Text;
using System.Windows.Forms;

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
			listBox1.Items.Clear();
			try
			{
				string fileName = textBox1.Text;       // The current source file
				FileInfo fi = new FileInfo(fileName);   // This source file

				string thisFile = fi.FullName,
					   thisDir = Directory.GetParent(thisFile).FullName;


				string[] files = Directory.GetFiles(thisDir);
				string[] dirs = Directory.GetDirectories(thisDir);

				listBox1.Items.Add(thisFile);
				listBox1.Items.Add(thisDir);
				foreach (string d in dirs)
					listBox1.Items.Add(d);
				foreach (string f in files)
					listBox1.Items.Add(f);
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

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
