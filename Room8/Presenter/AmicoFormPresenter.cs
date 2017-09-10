using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class AmicoFormPresenter
	{
		private readonly AmicoForm _amicoForm; 
		private readonly Utente _utente;

		public AmicoFormPresenter(AmicoForm amicoForm, Utente utente, Utente amico)
		{
			_amicoForm = amicoForm;
			_utente = utente;
			InitializeUI(amico);
		}

		public AmicoForm AmicoForm
		{
			get { return _amicoForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		private void InitializeUI(Utente amico)
		{
			AmicoForm.NomeAmicoLabel.Text = amico.Nome + " " + amico.Cognome;
			AmicoForm.PictureBox.ImageLocation = amico.Foto;
			AmicoForm.BilancioLabel.Text = Utente.CalcolaSituazione(amico).ToString("0.00 \u20AC");
		}
	}
}