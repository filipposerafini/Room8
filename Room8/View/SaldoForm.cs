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
    public partial class SaldoForm : Form
    {
        public SaldoForm()
        {
            InitializeComponent();
        }
        public ErrorProvider ErrorProvider
        {
            get { return _errorProvider; }
        }

        public ComboBox AComboBox
        {
            get { return _aComboBox; }
        }

        public ComboBox DaComboBox
        {
            get { return _daComboBox; }
        }

        public NumericUpDown NumericUpDown
        {
            get { return _numericUpDown; }
        }

        public DateTimePicker DateTimePicker
        {
            get { return _dateTimePicker; }
        }

        public Button ConfermaButton
        {
            get { return _confermaButton; }
        }

        public PictureBox APictureBox
        {
            get { return _aPictureBox; }
        }

        public PictureBox DaPictureBox
        {
            get { return _daPictureBox; }
        }

		public Button EliminaButton
		{
			get { return _eliminaButton; }
		}
    }
}
