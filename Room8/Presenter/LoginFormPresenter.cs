using System;
namespace Room8
{
	public class LoginFormPresenter
	{
		private readonly LoginForm _loginForm;
		private readonly GestoreUtenti _gestoreUtenti;

		public LoginFormPresenter(LoginForm loginForm)
		{
			if (loginForm == null)
				throw new ArgumentNullException("loginForm");
			_loginForm = loginForm;
			_gestoreUtenti = GestoreUtenti.Instance;

			InitializeEvents();
		}

		public LoginForm LoginForm
		{
			get { return _loginForm; }
		}

		public GestoreUtenti GestoreUtenti
		{
			get { return _gestoreUtenti; }
		}

		private void InitializeEvents()
		{
			LoginForm.AccediButton.Click += new EventHandler(AccediButton_Click);
			LoginForm.RegistratiButton.Click += new EventHandler(RegistratiButton_Click);
		}

		private void AccediButton_Click(object sender, EventArgs e)
		{
			try
			{
				Utente utente = GestoreUtenti.VerificaPassword(LoginForm.MailTextBox.Text, LoginForm.PasswordTextBox.Text);
				LoginForm.Hide();
				MainForm mainForm = new MainForm(utente);
				new MainFormPresenter();
				mainForm.Show();
			}
			catch (ArgumentException ex)
			{
				LoginForm.ErrorProvider.SetError(LoginForm.AccediButton, ex.Message);
			}
		}

		private void RegistratiButton_Click(object sender, EventArgs e)
		{
			//RegistratiForm registratiForm = new RegistratiForm();
			//new RegistratiFormPresenter(registratiForm);
			//registratiForm.Show();
		}
	}
}
