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
			button1.Location = new Point(623, 380);
			button1.Name = "button1";
			button1.Size = new Size(195, 110);
			button1.TabIndex = 6;
			button1.Text = "Read";
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(915, 583);
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
	}
}
