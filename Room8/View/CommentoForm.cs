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
    public partial class CommentoForm : Form
    {
        public CommentoForm()
        {
            InitializeComponent();
        }

		public TextBox CommentoTextBox
		{
			get { return _commentoTextBox; }
		}

		public ListBox CommentiListBox
		{
			get { return _commentiListBox; }
		}

		public Button CommentaButton
		{
			get { return _commentaButton; }
		}

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}
    }
}
