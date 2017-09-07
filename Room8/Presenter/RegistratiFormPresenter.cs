using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class RegistratiFormPresenter
	{
		private readonly RegistratiForm _registratiForm;
		private readonly LoginForm _loginForm;
		private readonly GestoreUtenti _gestoreUtenti;
		private string _foto;

		public RegistratiFormPresenter(RegistratiForm registratiForm, LoginForm loginForm)
		{
			this._registratiForm = registratiForm;
			this._loginForm = loginForm;
			this._gestoreUtenti = GestoreUtenti.Instance;
			this._foto = null;
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

		public string Foto
		{
			get { return _foto; }
			set { _foto = value; }
		}

		private void InitializeEvents()
		{
			RegistratiForm.FotoButton.Click += FotoButton_Click;
			RegistratiForm.ConfermaButton.Click += ConfermaButton_Click;
			RegistratiForm.AnnullaButton.Click += AnnullaButton_Click;
		}

		private void FotoButton_Click(object sender, EventArgs e)
		{
			RegistratiForm.ErrorProvider.Clear();
			if (RegistratiForm.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string foto = RegistratiForm.OpenFileDialog.FileName;
				Foto = foto;
				RegistratiForm.FileLabel.Text = foto.Substring(foto.LastIndexOf('/') + 1);
			}
		}

		private void ConfermaButton_Click(object sender, EventArgs e)
		{
			RegistratiForm.ErrorProvider.Clear();
			try 
			{
				if (!RegistratiForm.ConfermaPasswordTextBox.Text.Equals(RegistratiForm.PasswordTextBox.Text))
					throw new ArgumentException("Le password non corrispondono", "conferma");
				Utente utente = new Utente(RegistratiForm.MailTextBox.Text,
				                    	   RegistratiForm.PasswordTextBox.Text,
				                    	   RegistratiForm.NomeTextBox.Text,
				                    	   RegistratiForm.CognomeTextBox.Text,
				                           RegistratiForm.TelefonoTextBox.Text,
				                    	   Foto);
				GestoreUtenti.AggiugniUtente(utente);
				RegistratiForm.Hide();
				LoginForm.Show();
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "mail" :
						control = RegistratiForm.MailTextBox;
						break;
					case "password":
						control = RegistratiForm.PasswordTextBox;
						break;
					case "conferma":
						control = RegistratiForm.ConfermaPasswordTextBox;
						break;
					case "nome":
						control = RegistratiForm.NomeTextBox;
						break;
					case "cognome":
						control = RegistratiForm.CognomeTextBox;
						break;
					case "telefono":
						control = RegistratiForm.TelefonoTextBox;
						break;
					case "foto":
						control = RegistratiForm.FileLabel;
						break;
					default:
						control = RegistratiForm.ConfermaButton;
						break;
				}
				RegistratiForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}

		private void AnnullaButton_Click(object sender, EventArgs e)
		{
			RegistratiForm.Hide();
			LoginForm.Show();
		}
	}
}