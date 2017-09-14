using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Room8.View;
using System.Drawing;

namespace Room8
{
	class RegistratiFormPresenter
	{
		private readonly RegistratiForm _registratiForm;
		private readonly LoginForm _loginForm;
		private string _foto;

		public RegistratiFormPresenter(RegistratiForm registratiForm, LoginForm loginForm)
		{
			_registratiForm = registratiForm;
			_loginForm = loginForm;
			_foto = null;
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

		public string Foto
		{
			get { return _foto; }
			set
            {
                _foto = value; 
            }
		}

		private void InitializeEvents()
		{
			RegistratiForm.FotoButton.Click += FotoButton_Click;
			RegistratiForm.ConfermaButton.Click += ConfermaButton_Click;
			RegistratiForm.AnnullaButton.Click += AnnullaButton_Click;
			RegistratiForm.FormClosing += RegistratiForm_FormClosing;
		}

		private void FotoButton_Click(object sender, EventArgs e)
		{
			RegistratiForm.ErrorProvider.Clear();
            try
            {
                if (RegistratiForm.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Foto = RegistratiForm.OpenFileDialog.FileName;
                    Image.FromFile(Foto);
                    RegistratiForm.FileLabel.Text = Foto.Substring(Foto.LastIndexOf('\\') + 1);
                }
            }
            catch (OutOfMemoryException)
            {
                RegistratiForm.ErrorProvider.SetError(RegistratiForm.FileLabel, "Seleziona un'immagine valida");
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
				GestoreUtenti.Instance.AggiugniUtente(utente);
				AnnullaButton_Click(sender, e);
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
                        RegistratiForm.ErrorProvider.SetIconAlignment(RegistratiForm.ConfermaButton, ErrorIconAlignment.MiddleLeft);
						control = RegistratiForm.ConfermaButton;
						break;
				}
                RegistratiForm.ErrorProvider.SetError(control, string.IsNullOrEmpty(ae.ParamName) ?
                    ae.Message : ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}

		private void AnnullaButton_Click(object sender, EventArgs e)
		{ 
			RegistratiForm.Close(); 
		}

		private void RegistratiForm_FormClosing(object sender, FormClosingEventArgs e)
		{ 
			LoginForm.Show(); 
		}
	}
}