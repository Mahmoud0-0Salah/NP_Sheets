namespace SH_3_Q1
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
			richTextBox1 = new RichTextBox();
			button2 = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(8, 12);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(647, 271);
			richTextBox1.TabIndex = 0;
			richTextBox1.Text = "";
			richTextBox1.TextChanged += richTextBox1_TextChanged;
			// 
			// button2
			// 
			button2.Location = new Point(327, 328);
			button2.Name = "button2";
			button2.Size = new Size(279, 38);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(28, 328);
			button1.Name = "button1";
			button1.Size = new Size(279, 38);
			button1.TabIndex = 3;
			button1.Text = "Listen";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(671, 403);
			Controls.Add(button1);
			Controls.Add(button2);
			Controls.Add(richTextBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox richTextBox1;
		private Button button2;
		private Button button1;
	}
}
