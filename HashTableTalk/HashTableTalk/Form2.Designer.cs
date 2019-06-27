namespace HashTableTalk
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.captionLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.learnMorePictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// captionLabel
			// 
			this.captionLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.captionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.captionLabel.Location = new System.Drawing.Point(122, 33);
			this.captionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(902, 194);
			this.captionLabel.TabIndex = 3;
			this.captionLabel.Text = resources.GetString("captionLabel.Text");
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(122, 239);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 47);
			this.label1.TabIndex = 4;
			this.label1.Text = "Syntax:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(60, 286);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1046, 46);
			this.label2.TabIndex = 5;
			this.label2.Text = "Dictionary<string, string> openWith =  new Dictionary<string, string>();";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(60, 332);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1046, 46);
			this.label3.TabIndex = 6;
			this.label3.Text = "openWith.Add(\"txt\", \"notepad.exe\");";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(60, 378);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(1046, 46);
			this.label4.TabIndex = 7;
			this.label4.Text = "openWith.Add(\"bmp\", \"paint.exe\");";
			// 
			// learnMorePictureBox
			// 
			this.learnMorePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("learnMorePictureBox.Image")));
			this.learnMorePictureBox.Location = new System.Drawing.Point(1054, 423);
			this.learnMorePictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.learnMorePictureBox.Name = "learnMorePictureBox";
			this.learnMorePictureBox.Size = new System.Drawing.Size(101, 104);
			this.learnMorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.learnMorePictureBox.TabIndex = 8;
			this.learnMorePictureBox.TabStop = false;
			this.learnMorePictureBox.Click += new System.EventHandler(this.learnMorePictureBox_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1168, 540);
			this.Controls.Add(this.learnMorePictureBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.captionLabel);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Form2";
			this.Text = "Dictionaries";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox learnMorePictureBox;
	}
}