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
        public MainForm()
        {
            InitializeComponent();
        }

		public ListBox GruppiListBox
		{
			get { return _gruppiListBox; }
		}

		public ListBox AmiciListBox
		{
			get { return _amiciListBox; }
		}

		public Label BilancioImportoLabel
		{
			get { return _bilancioImportoLabel; }
		}

		public Label DeviImportoLabel
		{
			get { return _deviImportoLabel; }
		}

		public Label DovutoImportoLabel
		{
			get { return _dovutoImportoLabel; }
		}

		public ListBox AttivitaRecentiListBox
		{
			get { return _attivitaRecentiListBox; }
		}

		public Button SpesaButton
		{
			get { return _spesaButton; }
		}

		public Button SaldaButton
		{
			get { return _saldaButton; }
		}

		public PictureBox PictureBox
		{
			get { return _pictureBox; }
		}

		public ToolStripDropDownButton UtenteToolStrip
		{
			get { return _utenteToolStrip; }
		}

		public ToolStripMenuItem AccountToolStrip
		{
			get { return _accountToolStrip; }
		}

		public ToolStripMenuItem CreaGruppoToolStrip
		{
			get { return _creaGruppoToolStrip; }
		}

		public ToolStripMenuItem EsciToolStrip
		{
			get { return _esciToolStrip; }
		}
    }
}
