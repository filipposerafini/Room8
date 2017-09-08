using System;
using Room8.View;

namespace Room8
{
    public class MainFormPresenter : IPresenterEvent
	{
		private readonly MainForm _mainForm;
		private readonly LoginForm _loginForm;
		private readonly Utente _utente;

		public MainFormPresenter(MainForm mainForm, LoginForm loginForm, Utente utente)
		{   
			this._mainForm = mainForm;
			this._loginForm = loginForm;
			this._utente = utente;
			InitializeEvents();
			InitializeUI();
		}

		public MainForm MainForm
		{
			get { return _mainForm; }
		}

		public LoginForm LoginForm
		{
			get { return _loginForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		private void InitializeEvents()
		{
			MainForm.SpesaButton.Click += SpesaButton_Click;
			MainForm.SaldaButton.Click += SaldaButton_Click;
			MainForm.AmiciListBox.Click += AmiciListBox_Click;
			MainForm.AccountToolStrip.Click += AccountToolStrip_Click;
			MainForm.CreaGruppoToolStrip.Click += CreaGruppoToolStrip_Click;
			MainForm.EsciToolStrip.Click += EsciToolStrip_Click;
			MainForm.FormClosing += MainForm_FormClosing;
		}

		void InitializeUI()
		{
			MainForm.UtenteToolStrip.Text = Utente.Nome;
			MainForm.PictureBox.ImageLocation = Utente.Foto;
			MainForm.GruppiListBox.DataSource = Utente.Gruppi;
			MainForm.GruppiListBox.DisplayMember = "Nome";
			MainForm.AmiciListBox.DataSource = Utente.Amici();
			MainForm.AmiciListBox.DisplayMember = "Mail";
            this.Aggiorna();
		}

		private void SpesaButton_Click(object sender, EventArgs e)
		{
			SpesaForm spesaForm = new SpesaForm();
			new SpesaFormPresenter(spesaForm, Utente, null, this);
            spesaForm.ShowDialog();
		}

		private void SaldaButton_Click(object sender, EventArgs e)
		{
			SaldoForm saldoForm = new SaldoForm();
			new SaldoFormPresenter(saldoForm, Utente, this);
			saldoForm.ShowDialog();
		}

		void AmiciListBox_Click(object sender, EventArgs e)
		{
			AmicoForm amicoForm = new AmicoForm();
			new AmicoFormPresenter(amicoForm, Utente);
			amicoForm.ShowDialog();
		}

        public void Aggiorna()
        {
            // aggiorno il valore del bilancio
            MainForm.BilancioImportoLabel.Text = _utente.CalcolaBilancioTotale().ToString("#.##");
            MainForm.DeviImportoLabel.Text = _utente.TotaleDebiti().ToString("#.##");
            MainForm.DovutoImportoLabel.Text = _utente.TotaleCrediti().ToString("#.##");
        }

		private void AccountToolStrip_Click(object sender, EventArgs e)
		{
			ProfiloForm profiloForm = new ProfiloForm();
			new ProfiloFormPresenter(profiloForm, Utente);
			profiloForm.ShowDialog();
		}

		private void CreaGruppoToolStrip_Click(object sender, EventArgs e)
		{
			CreaGruppoForm creaGruppoForm = new CreaGruppoForm();
			new CreaGruppoFormPresenter(creaGruppoForm);
			creaGruppoForm.ShowDialog();
		}

		private void EsciToolStrip_Click(object sender, EventArgs e)
		{
			MainForm.Close();
		}
        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            LoginForm.Close();
        }
    }
}