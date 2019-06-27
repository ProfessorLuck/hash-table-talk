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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			captionLabel.BackColor = Color.Transparent;
			label1.BackColor = Color.Transparent;
			label2.BackColor = Color.Transparent;
			label3.BackColor = Color.Transparent;
			label4.BackColor = Color.Transparent;
			learnMorePictureBox.BackColor = Color.Transparent;
		}

		private void learnMorePictureBox_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3();
			f3.Show();
			this.Hide();
		}
	}
}
