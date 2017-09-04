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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRiepilogo_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageRiepilogo);
        }

        private void buttonAttivita_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageAttivita);
        }

        private void buttonSpese_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageSpese);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(tabPageRiepilogo);
        }

        private void listBoxGruppi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGruppi.SelectedIndex >= 0)
            {
                labelGruppoTitolo.Text = listBoxGruppi.Items[listBoxGruppi.SelectedIndex].ToString();
                listBoxAmici.SelectedIndex = -1;
                tabControlMain.SelectTab(tabPageGruppo);
            }
        }

        private void listBoxAmici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAmici.SelectedIndex >= 0)
            {
                listBoxGruppi.SelectedIndex = -1;
                labelAmicoTitolo.Text = listBoxAmici.Items[listBoxAmici.SelectedIndex].ToString();
                tabControlMain.SelectTab(tabPageAmico);
            }
        }
    }
}
