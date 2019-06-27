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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void learnMorePictureBox_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{ 
			captionLabel.BackColor = Color.Transparent;
			headerLabel.BackColor = Color.Transparent;
			learnMorePictureBox.BackColor = Color.Transparent;
		}
	}
}
