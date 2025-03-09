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
			button1 = new Button();
			button2 = new Button();
			groupBox1 = new GroupBox();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			textBox1 = new TextBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(384, 89);
			button1.Name = "button1";
			button1.Size = new Size(127, 47);
			button1.TabIndex = 0;
			button1.Text = "Open";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(384, 166);
			button2.Name = "button2";
			button2.Size = new Size(127, 47);
			button2.TabIndex = 1;
			button2.Text = "Save";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Location = new Point(19, 77);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(335, 136);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "IsAlive";
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(19, 79);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(50, 24);
			radioButton2.TabIndex = 1;
			radioButton2.TabStop = true;
			radioButton2.Text = "No";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(19, 35);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(51, 24);
			radioButton1.TabIndex = 0;
			radioButton1.TabStop = true;
			radioButton1.Text = "Yes";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(99, 29);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(255, 27);
			textBox1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 36);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 4;
			label1.Text = "Name";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(523, 241);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(groupBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private GroupBox groupBox1;
		private TextBox textBox1;
		private Label label1;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
	}
}
