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
    public partial class AmicoForm : Form
    {
        public AmicoForm()
        {
            InitializeComponent();
        }

		public Label NomeAmicoLabel
		{
			get { return _nomeAmicoLabel; }
		}

		public Label BilancioLabel
		{
			get { return _bilancioLabel; }
		}

		public Label ImportoLabel
		{
			get { return _importoLabel; }
		}

		public PictureBox PictureBox
		{
			get { return _pictureBox; }
		}

		public DataGridView DataGridView
		{
			get { return _dataGridView; }
		}

		public Button ModificaButton
		{
			get { return _modificaButton; }
		}
    }
}
