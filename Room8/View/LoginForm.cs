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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}

		public TextBox MailTextBox
		{
			get { return _mailTextBox; }
		}

		public TextBox PasswordTextBox
		{
			get { return _passwordTextBox; }
		}

		public Button AccediButton
		{
			get { return _accediButton; }
		}

		public Button RegistratiButton
		{
			get { return _registratiButton; }
		}
    }
}
