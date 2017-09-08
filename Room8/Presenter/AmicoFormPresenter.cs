using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class AmicoFormPresenter
	{
		private readonly AmicoForm _amicoForm; 
		private readonly Utente _utente;
		private readonly ListBox _listBox;

		public AmicoFormPresenter(AmicoForm amicoForm, Utente utente, ListBox listBox)
		{
			this._amicoForm = amicoForm;
			this._utente = utente;
			this._listBox = listBox;
			InitializeUI();
		}

		public AmicoForm AmicoForm
		{
			get { return _amicoForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		public ListBox ListBox
		{
			get { return _listBox; }
		}

		void InitializeUI()
		{
			Utente selezionato = (Utente)ListBox.SelectedItem;
			AmicoForm.NomeAmicoLabel.Text = selezionato.Nome + " " + selezionato.Cognome;
			AmicoForm.PictureBox.ImageLocation = selezionato.Foto;
			AmicoForm.BilancioLabel.Text = Utente.CalcolaSituazione(selezionato).ToString("0.00 \u20AC");
		}
	}
}