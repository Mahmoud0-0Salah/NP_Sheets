namespace Learn
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label2 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			richTextBox2 = new RichTextBox();
			button3 = new Button();
			button4 = new Button();
			textBox2 = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(237, 96);
			label2.Name = "label2";
			label2.Size = new Size(37, 20);
			label2.TabIndex = 1;
			label2.Text = "Path";
			label2.Click += label2_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(321, 96);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(254, 27);
			textBox1.TabIndex = 3;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ButtonFace;
			button1.Location = new Point(639, 239);
			button1.Name = "button1";
			button1.Size = new Size(195, 35);
			button1.TabIndex = 6;
			button1.Text = "Write Files";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// richTextBox2
			// 
			richTextBox2.Location = new Point(80, 215);
			richTextBox2.Name = "richTextBox2";
			richTextBox2.Size = new Size(511, 275);
			richTextBox2.TabIndex = 9;
			richTextBox2.Text = "";
			richTextBox2.TextChanged += richTextBox2_TextChanged;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.ButtonFace;
			button3.Location = new Point(639, 318);
			button3.Name = "button3";
			button3.Size = new Size(195, 35);
			button3.TabIndex = 13;
			button3.Text = "Clear Text";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.BackColor = SystemColors.ButtonFace;
			button4.Location = new Point(639, 407);
			button4.Name = "button4";
			button4.Size = new Size(195, 35);
			button4.TabIndex = 14;
			button4.Text = "Read Files";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(321, 144);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(254, 27);
			textBox2.TabIndex = 16;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(237, 144);
			label1.Name = "label1";
			label1.Size = new Size(45, 20);
			label1.TabIndex = 15;
			label1.Text = "Write";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(915, 583);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(richTextBox2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label2;
		private TextBox textBox1;
		private Button button1;
		private RichTextBox richTextBox2;
		private Button button3;
		private Button button4;
		private TextBox textBox2;
		private Label label1;
	}
}
