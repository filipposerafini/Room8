using Room8.View;
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
		private readonly Utente _utente;

        public MainForm(Utente utente)
        {
            InitializeComponent();
			this._utente = utente;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxGruppi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_gruppiListBox.SelectedIndex >= 0)
            {
               // _gruppoTitoloLabel.Text = _gruppiListBox.Items[_gruppiListBox.SelectedIndex].ToString();
                _amiciListBox.SelectedIndex = -1;
            }
        }

        private void listBoxAmici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_amiciListBox.SelectedIndex >= 0)
            {
                _gruppiListBox.SelectedIndex = -1;
                //_amicoTitoloLabel.Text = _amiciListBox.Items[_amiciListBox.SelectedIndex].ToString();              
            }
        }

        private void _aggiungiSpesaToolStripButton_Click(object sender, EventArgs e)
        {
            SpesaForm spesaForm = new SpesaForm();
			new SpesaFormPresenter(spesaForm, _utente);
			spesaForm.ShowDialog(this);
        }

        private void _saldaToolStripButton_Click(object sender, EventArgs e)
        {
            SaldoForm saldoForm = new SaldoForm();
            saldoForm.ShowDialog();
        }

        private void _linkLabelCrea_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreaGruppoForm gruppoForm = new CreaGruppoForm();
            gruppoForm.ShowDialog();
        }

        private void _creaGruppoToolStripButton_Click(object sender, EventArgs e)
        {
            CreaGruppoForm gruppoForm = new CreaGruppoForm();
            gruppoForm.ShowDialog();
        }

        private void _aggiungiSpesaButton_Click(object sender, EventArgs e)
        {
            SpesaForm spesaForm = new SpesaForm();
            spesaForm.ShowDialog();
        }

        private void _saldaButton_Click(object sender, EventArgs e)
        {
            SaldoForm saldoForm = new SaldoForm();
            saldoForm.ShowDialog();
        }
    }
}
