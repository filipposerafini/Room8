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
	public partial class RegistratiForm : Form
	{
		public RegistratiForm()
		{
			InitializeComponent();
		}

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}

		public TextBox NomeTextBox
		{
			get { return _nomeTextBox; }
		}

		public TextBox CognomeTextBox
		{
			get { return _cognomeTextBox; }
		}

		public TextBox MailTextBox
		{
			get { return _mailTextBox; }
		}

		public TextBox PasswordTextBox
		{
			get { return _passwordTextBox; }
		}

		public TextBox ConfermaPasswordTextBox
		{
			get { return _confermaPasswordTextBox; }
		}

		public TextBox TelefonoTextBox
		{
			get { return _telefonoTextBox; }
		}

		public Button AnnullaButton
		{
			get { return _annullaButton; }
		}

		public Button ConfermaButton
		{
			get { return _confermaButton; }
		}

		public TableLayoutPanel TableLayoutPanle
		{
			get { return _tableLayoutPanel; }
		}
	}
}
