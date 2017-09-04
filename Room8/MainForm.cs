using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonRiepilogo_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab(tabPageRiepilogo);
		}

		private void buttonAttivita_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab(tabPageAttivita);
		}

		private void buttonSpese_Click(object sender, EventArgs e)
		{
			tabControl.SelectTab(tabPageSpese);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tabControl.SelectTab(tabPageRiepilogo);
		}

	}
}
