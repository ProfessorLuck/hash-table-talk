namespace HashTableTalk
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.learnMorePictureBox = new System.Windows.Forms.PictureBox();
			this.headerLabel = new System.Windows.Forms.Label();
			this.captionLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// learnMorePictureBox
			// 
			this.learnMorePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("learnMorePictureBox.Image")));
			this.learnMorePictureBox.Location = new System.Drawing.Point(442, 371);
			this.learnMorePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.learnMorePictureBox.Name = "learnMorePictureBox";
			this.learnMorePictureBox.Size = new System.Drawing.Size(266, 104);
			this.learnMorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.learnMorePictureBox.TabIndex = 0;
			this.learnMorePictureBox.TabStop = false;
			this.learnMorePictureBox.Click += new System.EventHandler(this.learnMorePictureBox_Click);
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.headerLabel.Location = new System.Drawing.Point(434, 17);
			this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(268, 58);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Hash Tables";
			// 
			// captionLabel
			// 
			this.captionLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.captionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.captionLabel.Location = new System.Drawing.Point(124, 123);
			this.captionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(902, 194);
			this.captionLabel.TabIndex = 2;
			this.captionLabel.Text = "    A hash table maps keys to values. While an array is dependent on ordered inte" +
    "ger values as keys, a hash table generally allows the use of other data types, s" +
    "uch as string, char, float, etc. ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1168, 540);
			this.Controls.Add(this.captionLabel);
			this.Controls.Add(this.headerLabel);
			this.Controls.Add(this.learnMorePictureBox);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Hash Tables";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox learnMorePictureBox;
		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Label captionLabel;
	}
}

