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
			button4 = new Button();
			textBox2 = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(499, 214);
			label2.Name = "label2";
			label2.Size = new Size(43, 20);
			label2.TabIndex = 1;
			label2.Text = "From";
			label2.Click += label2_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(583, 214);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(254, 27);
			textBox1.TabIndex = 3;
			// 
			// button4
			// 
			button4.BackColor = SystemColors.ButtonFace;
			button4.Location = new Point(322, 305);
			button4.Name = "button4";
			button4.Size = new Size(254, 56);
			button4.TabIndex = 14;
			button4.Text = "Copy";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(174, 214);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(254, 27);
			textBox2.TabIndex = 16;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(90, 214);
			label1.Name = "label1";
			label1.Size = new Size(25, 20);
			label1.TabIndex = 15;
			label1.Text = "To";
			label1.Click += label1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(915, 583);
			Controls.Add(textBox2);
			Controls.Add(label1);
			Controls.Add(button4);
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
		private Button button4;
		private TextBox textBox2;
		private Label label1;
	}
}
