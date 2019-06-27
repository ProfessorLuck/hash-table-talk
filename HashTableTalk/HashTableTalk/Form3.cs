using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableTalk
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			captionLabel.BackColor = Color.Transparent;
			label1.BackColor = Color.Transparent;
			learnMorePictureBox.BackColor = Color.Transparent;
		}

		private void learnMorePictureBox_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.Show();
			this.Close();
		}
	}
}
