namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dice1txt = new System.Windows.Forms.TextBox();
			this.dice2txt = new System.Windows.Forms.TextBox();
			this.dice3txt = new System.Windows.Forms.TextBox();
			this.dice4txt = new System.Windows.Forms.TextBox();
			this.dicebtn = new System.Windows.Forms.Button();
			this.answerlbl = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// dice1txt
			// 
			this.dice1txt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dice1txt.Location = new System.Drawing.Point(61, 156);
			this.dice1txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dice1txt.Name = "dice1txt";
			this.dice1txt.Size = new System.Drawing.Size(76, 39);
			this.dice1txt.TabIndex = 0;
			this.dice1txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dice2txt
			// 
			this.dice2txt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dice2txt.Location = new System.Drawing.Point(194, 156);
			this.dice2txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dice2txt.Name = "dice2txt";
			this.dice2txt.Size = new System.Drawing.Size(76, 39);
			this.dice2txt.TabIndex = 1;
			this.dice2txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dice3txt
			// 
			this.dice3txt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dice3txt.Location = new System.Drawing.Point(324, 156);
			this.dice3txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dice3txt.Name = "dice3txt";
			this.dice3txt.Size = new System.Drawing.Size(76, 39);
			this.dice3txt.TabIndex = 2;
			this.dice3txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dice4txt
			// 
			this.dice4txt.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dice4txt.Location = new System.Drawing.Point(454, 156);
			this.dice4txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dice4txt.Name = "dice4txt";
			this.dice4txt.Size = new System.Drawing.Size(76, 39);
			this.dice4txt.TabIndex = 3;
			this.dice4txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dicebtn
			// 
			this.dicebtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dicebtn.Location = new System.Drawing.Point(255, 59);
			this.dicebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dicebtn.Name = "dicebtn";
			this.dicebtn.Size = new System.Drawing.Size(85, 50);
			this.dicebtn.TabIndex = 4;
			this.dicebtn.Text = "開骰";
			this.dicebtn.UseVisualStyleBackColor = true;
			this.dicebtn.Click += new System.EventHandler(this.dicebtn_Click);
			// 
			// answerlbl
			// 
			this.answerlbl.AutoSize = true;
			this.answerlbl.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.answerlbl.Location = new System.Drawing.Point(217, 251);
			this.answerlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.answerlbl.Name = "answerlbl";
			this.answerlbl.Size = new System.Drawing.Size(151, 37);
			this.answerlbl.TabIndex = 5;
			this.answerlbl.Text = "answerlbl";
			this.answerlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.Location = new System.Drawing.Point(61, 156);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(76, 39);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox2.Location = new System.Drawing.Point(194, 156);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(76, 39);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox3.Location = new System.Drawing.Point(324, 156);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(76, 39);
			this.textBox3.TabIndex = 2;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox4.Location = new System.Drawing.Point(454, 156);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(76, 39);
			this.textBox4.TabIndex = 3;
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.answerlbl);
			this.Controls.Add(this.dicebtn);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.dice4txt);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.dice3txt);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.dice2txt);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dice1txt);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox dice1txt;
		private System.Windows.Forms.TextBox dice2txt;
		private System.Windows.Forms.TextBox dice3txt;
		private System.Windows.Forms.TextBox dice4txt;
		private System.Windows.Forms.Button dicebtn;
		private System.Windows.Forms.Label answerlbl;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	}
}

