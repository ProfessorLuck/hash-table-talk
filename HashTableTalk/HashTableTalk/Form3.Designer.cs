namespace HashTableTalk
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.captionLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.learnMorePictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// captionLabel
			// 
			this.captionLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.captionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.captionLabel.Location = new System.Drawing.Point(121, 61);
			this.captionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(902, 100);
			this.captionLabel.TabIndex = 4;
			this.captionLabel.Text = "    In languages like Javascript and Python, the syntax is less tedious:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(215, 186);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(683, 100);
			this.label1.TabIndex = 5;
			this.label1.Text = "my_dict = {\"item1\": \'a\', \"item2\": \'b\', \"item3\": \'c\'}";
			// 
			// learnMorePictureBox
			// 
			this.learnMorePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("learnMorePictureBox.Image")));
			this.learnMorePictureBox.Location = new System.Drawing.Point(1054, 423);
			this.learnMorePictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.learnMorePictureBox.Name = "learnMorePictureBox";
			this.learnMorePictureBox.Size = new System.Drawing.Size(101, 104);
			this.learnMorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.learnMorePictureBox.TabIndex = 9;
			this.learnMorePictureBox.TabStop = false;
			this.learnMorePictureBox.Click += new System.EventHandler(this.learnMorePictureBox_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1168, 540);
			this.Controls.Add(this.learnMorePictureBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.captionLabel);
			this.Name = "Form3";
			this.Text = "Javascript and Python";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label captionLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox learnMorePictureBox;
	}
}