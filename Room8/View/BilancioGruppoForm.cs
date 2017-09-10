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
    public partial class BilancioGruppoForm : Form
    {
        public BilancioGruppoForm()
        {
            InitializeComponent();
        }

		public Label GruppoLabel
		{
			get { return _registratiLabel; }
		}

		public Label BilancioLabel
		{
			get { return _bilancioImportoLabel; }
		}

		public PictureBox PictureBox
		{
			get { return _pictureBox; }
		}

		public ListBox MembriListBox
		{
			get { return _membriListBox; }
		}

		public DataGridView DataGridView
		{
			get { return _dataGridView; }
		}

		public Button ModificaButton
		{
			get { return _modificaButton; }
		}

		public Button ProdottiButton
		{
			get { return _prodottiButton; }
		}
    }
}
