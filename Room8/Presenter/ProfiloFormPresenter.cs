using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class ProfiloFormPresenter
	{
		private readonly ProfiloForm _profiloForm;
		private readonly Utente _utente;
        private IPresenterEvent _observer;

		public ProfiloFormPresenter(ProfiloForm profiloForm, Utente utente)
		{
			_profiloForm = profiloForm;
			_utente = utente;
			InitializeEvents();
			InitializeUI();
		}

        public void Attach(IPresenterEvent observer)
        {
            _observer = observer;
        }

		public ProfiloForm ProfiloForm
		{
			get { return _profiloForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		public IPresenterEvent Observer
		{
			get { return _observer; }
		}

		private void InitializeEvents()
		{
			ProfiloForm.ConfermaButton.Click += ConfermaButton_Click;
			ProfiloForm.FotoButton.Click += FotoButton_Click;
		}

		private void InitializeUI()
		{
			ProfiloForm.NomeTextBox.Text = Utente.Nome;
			ProfiloForm.CognomeTextBox.Text = Utente.Cognome;
			ProfiloForm.MailTextBox.Text = Utente.Mail;
			ProfiloForm.TelefonoTextBox.Text = Utente.Telefono;
			ProfiloForm.PictureBox.Load(Utente.Foto);
			ProfiloForm.FileLabel.Text = Utente.Foto.Substring(Utente.Foto.LastIndexOf('\\') + 1);
		}

		private void FotoButton_Click(object sender, System.EventArgs e)
		{
			ProfiloForm.ErrorProvider.Clear();
            try
            {
                if (ProfiloForm.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string foto = ProfiloForm.OpenFileDialog.FileName;
                    ProfiloForm.FileLabel.Text = foto.Substring(foto.LastIndexOf('\\') + 1);
                    ProfiloForm.PictureBox.Load(foto);
                }
            }
            catch (ArgumentException)
            {
                ProfiloForm.ErrorProvider.SetIconAlignment(ProfiloForm.FotoButton, ErrorIconAlignment.MiddleLeft);
                ProfiloForm.ErrorProvider.SetError(ProfiloForm.FotoButton, "Seleziona un'immagine valida");
            }
		}

		private void ConfermaButton_Click(object sender, System.EventArgs e)
		{
			ProfiloForm.ErrorProvider.Clear();
			try
			{
				Utente.Nome = ProfiloForm.NomeTextBox.Text;
				Utente.Cognome = ProfiloForm.CognomeTextBox.Text;
				Utente.Mail = ProfiloForm.MailTextBox.Text;
				Utente.Telefono = ProfiloForm.TelefonoTextBox.Text;
				Utente.Foto = ProfiloForm.PictureBox.ImageLocation;

				if (!string.IsNullOrEmpty(ProfiloForm.NuovaPassword.Text))
				{
					if (!ProfiloForm.VecchiaPassword.Text.Equals(Utente.Password))
						throw new ArgumentException("La vecchia password non corrisponde", "vecchia");
					if (!ProfiloForm.NuovaPassword.Text.Equals(ProfiloForm.ConfermaPassword.Text))
						throw new ArgumentException("Le password non corrispondono", "conferma");
					Utente.Password = ProfiloForm.NuovaPassword.Text;
				}

				Observer.AggiornaUI();
				ProfiloForm.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "mail":
						control = ProfiloForm.MailTextBox;
						break;
					case "vecchia" :
						control = ProfiloForm.VecchiaPassword;
						break;
					case "password":
						control = ProfiloForm.NuovaPassword;
						break;
					case "conferma":
						control = ProfiloForm.ConfermaPassword;
						break;
					case "nome":
						control = ProfiloForm.NomeTextBox;
						break;
					case "cognome":
						control = ProfiloForm.CognomeTextBox;
						break;
					case "telefono":
						control = ProfiloForm.TelefonoTextBox;
						break;
                    case "file":
                        control = ProfiloForm.FileLabel;
                        break;
					default:
                        ProfiloForm.ErrorProvider.SetIconAlignment(ProfiloForm.ConfermaButton, ErrorIconAlignment.MiddleLeft);
						control = ProfiloForm.ConfermaButton;
						break;
				}
                ProfiloForm.ErrorProvider.SetError(control, string.IsNullOrEmpty(ae.ParamName) ?
                    ae.Message : ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}
	}
}