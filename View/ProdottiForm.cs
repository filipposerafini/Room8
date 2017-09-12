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
    public partial class ProdottiForm : Form
    {
        public ProdottiForm()
        {
            InitializeComponent();
        }

		public TextBox ProdottoTextBox
		{
			get { return _prodottoTextBox; }
		}

		public Button AggiungiButton
		{
			get { return _aggiungiButton; }
		}

		public Button RimuoviButton
		{
			get { return _rimuoviButton; }
		}

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}

		public DataGridView DataGridView
		{
			get { return _dataGridView; }
		}

		public NumericUpDown NumericUpDown
		{
			get { return _numericUpDown; }
		}
    }
}
