using Room8.View;
using System;
using System.Windows.Forms;

namespace Room8
{
	public class LoginFormPresenter
	{
		private readonly LoginForm _loginForm;

		public LoginFormPresenter(LoginForm loginForm)
		{
			_loginForm = loginForm;
			InitializeEvents();
		}

		public LoginForm LoginForm
		{
			get { return _loginForm; }
		}

		private void InitializeEvents()
		{
			LoginForm.AccediButton.Click += AccediButton_Click;
			LoginForm.RegistratiButton.Click += RegistratiButton_Click;
		}

		private void AccediButton_Click(object sender, EventArgs e)
		{
			LoginForm.ErrorProvider.Clear();
			try
			{
				Utente utente = GestoreUtenti.Instance.VerificaPassword(LoginForm.MailTextBox.Text, LoginForm.PasswordTextBox.Text);
				LoginForm.Hide();
				MainForm mainForm = new MainForm();
				new MainFormPresenter(mainForm, LoginForm, utente);
				mainForm.Show();
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "mail" :
						control = LoginForm.MailTextBox;
						break;
					case "password" :
						control = LoginForm.PasswordTextBox;
						break;
					default:
						control = LoginForm.AccediButton;
						break;
				}
				LoginForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}

		private void RegistratiButton_Click(object sender, EventArgs e)
		{
			RegistratiForm registratiForm = new RegistratiForm();
			new RegistratiFormPresenter(registratiForm, LoginForm);
			LoginForm.Hide();
			registratiForm.Show();
		}
	}
}
