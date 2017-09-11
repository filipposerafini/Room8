using System;
using System.Drawing;
using System.Linq;
using Room8.View;
using System.Windows.Forms;

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
			AggiornaUI();
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
			MainForm.SpeseDataGridView.Click += SpeseDataGridView_Click;
			MainForm.SaldiDataGridView.Click += SaldiDataGridView_Click;
			MainForm.AmiciListBox.Click += AmiciListBox_Click;
			MainForm.GruppiListBox.Click += GruppiListBox_Click;
			MainForm.AccountToolStrip.Click += AccountToolStrip_Click;
			MainForm.CreaGruppoToolStrip.Click += CreaGruppoToolStrip_Click;
			MainForm.EsciToolStrip.Click += EsciToolStrip_Click;
			MainForm.FormClosing += MainForm_FormClosing;
		}

		public void AggiornaUI()
		{
			MainForm.UtenteToolStrip.Text = Utente.Nome;
			MainForm.PictureBox.Load(Utente.Foto);
			MainForm.GruppiListBox.DataSource = Utente.Gruppi;
			MainForm.GruppiListBox.DisplayMember = "Nome";
			MainForm.AmiciListBox.DataSource = Utente.Amici();
			MainForm.AmiciListBox.DisplayMember = "Mail";

			MainForm.SpeseDataGridView.DataSource = Utente.GetSpese();
			MainForm.SpeseDataGridView.Enabled = MainForm.SpeseDataGridView.RowCount != 0;
			MainForm.SaldiDataGridView.DataSource = Utente.GetSaldi();
			MainForm.SaldiDataGridView.Enabled = MainForm.SaldiDataGridView.RowCount != 0;

			decimal bilancioTotale = Utente.CalcolaBilancioTotale();
			MainForm.BilancioImportoLabel.Text = bilancioTotale.ToString("€ 0.00");
			if (bilancioTotale < 0)
				MainForm.BilancioImportoLabel.ForeColor = Color.Red;
			else
				MainForm.BilancioImportoLabel.ForeColor = Color.Green;
			MainForm.DeviImportoLabel.Text = Utente.TotaleDebiti().ToString("€ 0.00");
			MainForm.DeviImportoLabel.ForeColor = Color.Red;
			MainForm.DovutoImportoLabel.Text = Utente.TotaleCrediti().ToString("€ 0.00");
			MainForm.DovutoImportoLabel.ForeColor = Color.Green;
		}

		private void SpesaButton_Click(object sender, EventArgs e)
		{
			SpesaForm spesaForm = new SpesaForm();
			new SpesaFormPresenter(spesaForm, Utente, this, null);
			spesaForm.ShowDialog();
		}

		private void SaldaButton_Click(object sender, EventArgs e)
		{
			SaldoForm saldoForm = new SaldoForm();
			new SaldoFormPresenter(saldoForm, Utente, this, null);
			saldoForm.ShowDialog();
		}

		void SpeseDataGridView_Click(object sender, EventArgs e)
		{
			SpesaForm spesaForm = new SpesaForm();
			Spesa spesa = (Spesa)MainForm.SpeseDataGridView.CurrentRow.DataBoundItem;
			new SpesaFormPresenter(spesaForm, Utente, this, spesa);
			spesaForm.ShowDialog();
		}

		void SaldiDataGridView_Click(object sender, EventArgs e)
		{
			SaldoForm saldoForm = new SaldoForm();
			Saldo saldo = (Saldo)MainForm.SaldiDataGridView.CurrentRow.DataBoundItem;
			new SaldoFormPresenter(saldoForm, Utente, this, saldo);
			saldoForm.ShowDialog();
		}

		private void AmiciListBox_Click(object sender, EventArgs e)
		{
            AmicoForm amicoForm = new AmicoForm();
			new AmicoFormPresenter(amicoForm, Utente, (Utente)MainForm.AmiciListBox.SelectedItem);
            amicoForm.ShowDialog();
		}

		private void GruppiListBox_Click(object sender, EventArgs e)
		{
            BilancioGruppoForm bilancioGruppoForm = new BilancioGruppoForm();
			new BilancioGruppoFormPresenter(bilancioGruppoForm, Utente, (Gruppo)MainForm.GruppiListBox.SelectedItem, this);
            bilancioGruppoForm.ShowDialog();
		}

		private void AccountToolStrip_Click(object sender, EventArgs e)
		{
			ProfiloForm profiloForm = new ProfiloForm();
			new ProfiloFormPresenter(profiloForm, Utente, this);
			profiloForm.ShowDialog();
		}

		private void CreaGruppoToolStrip_Click(object sender, EventArgs e)
		{
			GruppoForm gruppoForm = new GruppoForm();
			new GruppoFormPresenter(gruppoForm, Utente, null, this);
			gruppoForm.ShowDialog();
		}

		private void EsciToolStrip_Click(object sender, EventArgs e)
		{
			MainForm.Close();
		}
		private void MainForm_FormClosing(object sender, EventArgs e)
		{
			LoginForm.Show();
		}
	}
}