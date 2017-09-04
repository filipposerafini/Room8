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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRiepilogo_Click(object sender, EventArgs e)
        {
            _mainTabControl.SelectTab(_riepilogoTabPage);
        }

        private void buttonAttivita_Click(object sender, EventArgs e)
        {
            _mainTabControl.SelectTab(_attivitaTabPage);
        }

        private void buttonSpese_Click(object sender, EventArgs e)
        {
            _mainTabControl.SelectTab(_speseTabPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainTabControl.SelectTab(_riepilogoTabPage);
        }

        private void listBoxGruppi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_gruppiListBox.SelectedIndex >= 0)
            {
                _gruppoTitoloLabel.Text = _gruppiListBox.Items[_gruppiListBox.SelectedIndex].ToString();
                _amiciListBox.SelectedIndex = -1;
                _mainTabControl.SelectTab(_gruppoTabPage);
            }
        }

        private void listBoxAmici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_amiciListBox.SelectedIndex >= 0)
            {
                _gruppiListBox.SelectedIndex = -1;
                _amicoTitoloLabel.Text = _amiciListBox.Items[_amiciListBox.SelectedIndex].ToString();
                _mainTabControl.SelectTab(_amicoTabPage);
            }
        }
    }
}
