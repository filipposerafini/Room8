using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Room8.View
{
    public partial class GruppoForm : Form
    {
        public GruppoForm()
        {
            InitializeComponent();
        }

		public TextBox NomeGruppoTextBox
		{
			get { return _nomeGruppoTextBox; }
		}

		public PictureBox PictureBox
		{
			get { return _pictureBox; }
		}

		public Button FotoButton
		{
			get { return _fotoButton; }
		}

		public Label FileLabel
		{
			get { return _fileLabel; }
		}

		public OpenFileDialog OpenFileDialog
		{
			get { return _openFileDialog; }
		}

		public Button ConfermaButton
		{
			get { return _confermaButton; }
		}

		public LinkLabel AggiungiPersonaLinkLabel
		{
			get { return _aggiungiPersonaLinkLabel; }
		}

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}

		public TableLayoutPanel MembriTable
		{
			get { return _addUserTableLayoutPanel; }
		}
    }
}
