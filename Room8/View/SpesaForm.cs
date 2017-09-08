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
    public partial class SpesaForm : Form
    {
        public SpesaForm()
        {
            InitializeComponent();
        }

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}

		public Label SpesaLabel
		{
			get { return _spesaLabel; }
		}

		public Button ConfermaButton
		{
			get { return _confermaButton; }
		}

		public ComboBox GruppoComboBox
		{
			get { return _gruppoComboBox; }
		}

		public TextBox DescrizioneTextBox
		{
			get { return _descrizioneTextBox; }
		}

		public Panel RadioPanel
		{
			get { return _radioPanel; }
		}

		public RadioButton EquoRadioButton
		{
			get { return _equoRadioButton; }
		}

		public RadioButton QuoteRadioButton
		{
			get { return _quoteRadioButton; }
		}

		public RadioButton PercentualeRadioButton
		{
			get { return _percentualeRadioButton; }
		}

        public RadioButton ImportiPrecisiRadioButton
        {
            get { return _importiPrecisiRadioButton; }
        }

		public ComboBox PaganteComboBox
		{
			get { return _paganteComboBox; }
		}

		public DateTimePicker DateTimePicker
		{
			get { return _dateTimePicker; }
		}

		public NumericUpDown NumericUpDown
		{
			get { return _numericUpDown; }
		}

        private void _commentoButton_Click(object sender, EventArgs e)
        {
            CommentoForm commentoForm = new CommentoForm();
            commentoForm.ShowDialog();
        }
    }
}
