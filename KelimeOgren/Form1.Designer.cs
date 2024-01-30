namespace KelimeOgren
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtIngilizce = new System.Windows.Forms.TextBox();
			this.TxtTurkce = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LblSure = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.LblKelime = new System.Windows.Forms.Label();
			this.LblCevap = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "İngilizce : ";
			// 
			// TxtIngilizce
			// 
			this.TxtIngilizce.Location = new System.Drawing.Point(153, 46);
			this.TxtIngilizce.Name = "TxtIngilizce";
			this.TxtIngilizce.Size = new System.Drawing.Size(263, 30);
			this.TxtIngilizce.TabIndex = 10;
			// 
			// TxtTurkce
			// 
			this.TxtTurkce.Location = new System.Drawing.Point(153, 91);
			this.TxtTurkce.Name = "TxtTurkce";
			this.TxtTurkce.Size = new System.Drawing.Size(263, 30);
			this.TxtTurkce.TabIndex = 1;
			this.TxtTurkce.TextChanged += new System.EventHandler(this.TxtTurkce_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Türkçe : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(481, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Süre : ";
			// 
			// LblSure
			// 
			this.LblSure.AutoSize = true;
			this.LblSure.Location = new System.Drawing.Point(543, 52);
			this.LblSure.Name = "LblSure";
			this.LblSure.Size = new System.Drawing.Size(33, 24);
			this.LblSure.TabIndex = 5;
			this.LblSure.Text = "90";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(458, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 24);
			this.label5.TabIndex = 6;
			this.label5.Text = "Kelime : ";
			// 
			// LblKelime
			// 
			this.LblKelime.AutoSize = true;
			this.LblKelime.Location = new System.Drawing.Point(547, 76);
			this.LblKelime.Name = "LblKelime";
			this.LblKelime.Size = new System.Drawing.Size(22, 24);
			this.LblKelime.TabIndex = 7;
			this.LblKelime.Text = "0";
			// 
			// LblCevap
			// 
			this.LblCevap.AutoSize = true;
			this.LblCevap.Location = new System.Drawing.Point(458, 131);
			this.LblCevap.Name = "LblCevap";
			this.LblCevap.Size = new System.Drawing.Size(64, 24);
			this.LblCevap.TabIndex = 8;
			this.LblCevap.Text = "label4";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(950, 462);
			this.Controls.Add(this.LblCevap);
			this.Controls.Add(this.LblKelime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.LblSure);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtTurkce);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtIngilizce);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtIngilizce;
		private System.Windows.Forms.TextBox TxtTurkce;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblSure;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label LblKelime;
		private System.Windows.Forms.Label LblCevap;
		private System.Windows.Forms.Timer timer1;
	}
}

