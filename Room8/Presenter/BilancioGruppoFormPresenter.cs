using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class BilancioGruppoFormPresenter
	{
		private readonly BilancioGruppoForm _bilancioGruppoForm;
		private readonly Utente _utente;
		private readonly Gruppo _gruppo;

		public BilancioGruppoFormPresenter(BilancioGruppoForm bilancioGruppoForm, Utente utente, Gruppo gruppo)
		{
			this._bilancioGruppoForm = bilancioGruppoForm;
			this._utente = utente;
			this._gruppo = gruppo;
			InitializeEvents();
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

		public Gruppo Gruppo
		{
			get { return _gruppo; }
		}

		void InitializeEvents()
		{
			BilancioGruppoForm.ModificaButton.Click += ModificaButton_Click;
			BilancioGruppoForm.ProdottiButton.Click += ProdottiButton_Click;
			BilancioGruppoForm.MembriListBox.Click += MembriListBox_Click;
		}

		void InitializeUI()
		{
			BilancioGruppoForm.GruppoLabel.Text = Gruppo.Nome;
			BilancioGruppoForm.PictureBox.ImageLocation = Gruppo.Foto;
			BilancioGruppoForm.BilancioLabel.Text = Utente.CalcolaBilancio(Gruppo).ToString("0.00 \u20AC");
            BilancioGruppoForm.MembriListBox.DataSource = Gruppo.MembriGruppo;
            BilancioGruppoForm.MembriListBox.DisplayMember = "Mail";
        }

		void MembriListBox_Click(object sender, EventArgs e)
		{
			AmicoForm amicoForm = new AmicoForm();
			new AmicoFormPresenter(amicoForm, Utente, (Utente)BilancioGruppoForm.MembriListBox.SelectedItem);
			amicoForm.ShowDialog();
		}

		void ModificaButton_Click(object sender, EventArgs e)
		{
			GruppoForm gruppoForm = new GruppoForm();
			new GruppoFormPresenter(gruppoForm, Utente, Gruppo);
			gruppoForm.ShowDialog();
		}

		void ProdottiButton_Click(object sender, EventArgs e)
		{
			ProdottiForm prodottiForm = new ProdottiForm();
			new ProdottiFormPresenter(prodottiForm, Gruppo);
			prodottiForm.ShowDialog();
		}
	}
}