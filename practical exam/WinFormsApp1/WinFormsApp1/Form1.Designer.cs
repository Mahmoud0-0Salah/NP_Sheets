namespace WinFormsApp1
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
			button1 = new Button();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			richTextBox1 = new RichTextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(85, 359);
			button1.Name = "button1";
			button1.Size = new Size(207, 51);
			button1.TabIndex = 0;
			button1.Text = "Send";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(395, 359);
			button2.Name = "button2";
			button2.Size = new Size(207, 51);
			button2.TabIndex = 1;
			button2.Text = "Receive";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(168, 119);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(390, 210);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 22);
			label1.Name = "label1";
			label1.Size = new Size(146, 20);
			label1.TabIndex = 3;
			label1.Text = "Message from server";
			label1.Click += label1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(168, 19);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(626, 78);
			richTextBox1.TabIndex = 4;
			richTextBox1.Text = "";
			richTextBox1.TextChanged += richTextBox1_TextChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(richTextBox1);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private PictureBox pictureBox1;
		private Label label1;
		private RichTextBox richTextBox1;
	}
}
