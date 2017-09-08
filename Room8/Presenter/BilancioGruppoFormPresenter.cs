using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class BilancioGruppoFormPresenter
	{
		private readonly BilancioGruppoForm _bilancioGruppoForm;
		private readonly Utente _utente;
		private readonly ListBox _listBox;

		public BilancioGruppoFormPresenter(BilancioGruppoForm bilancioGruppoForm, Utente utente, ListBox listBox)
		{
			this._bilancioGruppoForm = bilancioGruppoForm;
			this._utente = utente;
			InitializeUI();
		}

		public BilancioGruppoForm BilancioGruppoForm
		{
			get { return _bilancioGruppoForm; }
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
			Gruppo selezionato = (Gruppo)ListBox.SelectedItem;
			BilancioGruppoForm.GruppoLabel.Text = selezionato.Nome;
			BilancioGruppoForm.PictureBox.ImageLocation = selezionato.Foto;
			BilancioGruppoForm.BilancioLabel.Text = Utente.CalcolaSituazione(Utente, selezionato).ToString("0.00 \u20AC");
		}
	}
}