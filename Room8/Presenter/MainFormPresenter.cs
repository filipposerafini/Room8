using System;
using Room8.View;

namespace Room8
{
	public class MainFormPresenter
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
			MainForm.EsciToolStrip.Click += EsciToolStrip_Click;
		}

		private void SpesaButton_Click(object sender, EventArgs e)
		{
			SpesaForm spesaForm = new SpesaForm();
			new SpesaFormPresenter(spesaForm, Utente);
			spesaForm.ShowDialog();
		}

		private void SaldaButton_Click(object sender, EventArgs e)
		{
			SaldoForm saldoForm = new SaldoForm();
			new SaldoFormPresenter(saldoForm, Utente);
			saldoForm.ShowDialog();
		}

		void EsciToolStrip_Click(object sender, EventArgs e)
		{
			MainForm.Close();
			LoginForm.Show();
		}
	}
}
