using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTableTalk
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		public string run_cmd(string cmd, string args)
		{
			ProcessStartInfo start = new ProcessStartInfo();
			start.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python36_64\python.exe";
			start.Arguments = string.Format("\"{0}\" \"{1}\"", cmd, args);
			start.UseShellExecute = false;
			start.CreateNoWindow = true;
			start.RedirectStandardOutput = true;
			start.RedirectStandardError = true;
			using (Process process = Process.Start(start))
			{
				using (StreamReader reader = process.StandardOutput)
				{
					string stderr = process.StandardError.ReadToEnd();
					string result = reader.ReadToEnd();
					return result;
				}
			}
		}

		private void learnMorePictureBox_Click(object sender, EventArgs e)
		{

		}
	}
}