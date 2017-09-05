using System;
using System.Text.RegularExpressions;
using Room8.View;

namespace Room8
{
	class RegistratiFormPresenter
	{
		private readonly RegistratiForm _registratiForm;
		private readonly LoginForm _loginForm;
		private readonly GestoreUtenti _gestoreUtenti;

		public RegistratiFormPresenter(RegistratiForm registratiForm, LoginForm loginForm)
		{
			this._registratiForm = registratiForm;
			this._loginForm = loginForm;
			this._gestoreUtenti = GestoreUtenti.Instance;
			InitializeEvents();
		}

		public RegistratiForm RegistratiForm
		{
			get { return _registratiForm; }
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
			RegistratiForm.ConfermaButton.Click += new EventHandler(ConfermaButton_Click);
			RegistratiForm.AnnullaButton.Click += new EventHandler(AnnullaButton_Click);
		}

		private void ConfermaButton_Click(object sender, EventArgs e)
		{
			RegistratiForm.ErrorProvider.Clear();
			if (string.IsNullOrEmpty(RegistratiForm.NomeTextBox.Text))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.NomeTextBox, "Campo necessario");
			else if (!Regex.IsMatch(RegistratiForm.NomeTextBox.Text, @"[A-z]{1,}"))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.NomeTextBox, "Inserisci un nome valido");
			else if (string.IsNullOrEmpty(RegistratiForm.CognomeTextBox.Text))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.CognomeTextBox, "Campo necessario");
			else if (!Regex.IsMatch(RegistratiForm.CognomeTextBox.Text, @"[A-z]{1,}"))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.CognomeTextBox, "Inserisci un cognome valido");
			else if (string.IsNullOrEmpty(RegistratiForm.MailTextBox.Text))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.MailTextBox, "Campo necessario");
			else if (!Regex.IsMatch(RegistratiForm.MailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.MailTextBox, "Inserisci una mail valida");
			else if (string.IsNullOrEmpty(RegistratiForm.PasswordTextBox.Text))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.ConfermaPasswordTextBox, "Campo necessario");
			else if (!Regex.IsMatch(RegistratiForm.PasswordTextBox.Text, @".{8,}"))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.PasswordTextBox, "La password deve contenere almano di 8 caratteri");
			else if (string.IsNullOrEmpty(RegistratiForm.ConfermaPasswordTextBox.Text))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.ConfermaPasswordTextBox, "Campo necessario");
			else if (!RegistratiForm.ConfermaPasswordTextBox.Text.Equals(RegistratiForm.PasswordTextBox.Text))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.ConfermaPasswordTextBox, "Le password non corrispondono");
			else if (string.IsNullOrEmpty(RegistratiForm.TelefonoTextBox.Text))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.TelefonoTextBox, "Campo necessario");
			else if (!Regex.IsMatch(RegistratiForm.TelefonoTextBox.Text,@"\+?[0-9]{8,}"))
				RegistratiForm.ErrorProvider.SetError(RegistratiForm.TelefonoTextBox, "Inserisci un telefono valido");
			else
			{
				Utente utente = new Utente(RegistratiForm.MailTextBox.Text,
										   RegistratiForm.PasswordTextBox.Text,
										   RegistratiForm.NomeTextBox.Text,
										   RegistratiForm.CognomeTextBox.Text);
				GestoreUtenti.AggiugniUtente(utente);
				RegistratiForm.Hide();
				LoginForm.Show();
			}
			
		}

		private void AnnullaButton_Click(object sender, EventArgs e)
		{
			RegistratiForm.Hide();
			LoginForm.Show();
		}
	}
}