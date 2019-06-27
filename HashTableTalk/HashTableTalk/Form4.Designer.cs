namespace HashTableTalk
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.learnMorePictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// learnMorePictureBox
			// 
			this.learnMorePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("learnMorePictureBox.Image")));
			this.learnMorePictureBox.Location = new System.Drawing.Point(534, 218);
			this.learnMorePictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.learnMorePictureBox.Name = "learnMorePictureBox";
			this.learnMorePictureBox.Size = new System.Drawing.Size(101, 104);
			this.learnMorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.learnMorePictureBox.TabIndex = 10;
			this.learnMorePictureBox.TabStop = false;
			this.learnMorePictureBox.Click += new System.EventHandler(this.learnMorePictureBox_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1168, 540);
			this.Controls.Add(this.learnMorePictureBox);
			this.Name = "Form4";
			this.Text = "Python";
			((System.ComponentModel.ISupportInitialize)(this.learnMorePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox learnMorePictureBox;
	}
}