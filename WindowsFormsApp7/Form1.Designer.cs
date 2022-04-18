namespace WindowsFormsApp7
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button8 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(236, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "1. 보간식과 string.format 속도 비교하기";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(343, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(50, 21);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "1000";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(399, 13);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(82, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "제거후 저장";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 42);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(318, 21);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "10,15,25,27,35,40";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(336, 42);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(145, 21);
			this.button5.TabIndex = 5;
			this.button5.Text = "지우기후 파일새로저장";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "시간대표시";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(268, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(212, 42);
			this.button2.TabIndex = 7;
			this.button2.Text = "바이너리라이터쓰기";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(336, 73);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(14, 104);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(234, 42);
			this.button6.TabIndex = 9;
			this.button6.Text = "2.StreamWriter쓰기";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(14, 152);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(625, 183);
			this.textBox3.TabIndex = 10;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(513, 10);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(126, 83);
			this.button7.TabIndex = 11;
			this.button7.Text = "button7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(513, 99);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 21);
			this.textBox4.TabIndex = 12;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(523, 126);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 13;
			this.button8.Text = "button8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 347);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "로또";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button8;
	}
}

