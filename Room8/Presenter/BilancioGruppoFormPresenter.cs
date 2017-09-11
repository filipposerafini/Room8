﻿using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	public class BilancioGruppoFormPresenter : IPresenterEvent
	{
		private readonly BilancioGruppoForm _bilancioGruppoForm;
		private readonly Utente _utente;
		private readonly Gruppo _gruppo;
		private readonly IPresenterEvent _observer;

		public BilancioGruppoFormPresenter(BilancioGruppoForm bilancioGruppoForm, Utente utente, Gruppo gruppo, IPresenterEvent observer)
		{
			_bilancioGruppoForm = bilancioGruppoForm;
			_utente = utente;
			_gruppo = gruppo;
			_observer = observer;
			InitializeEvents();
			AggiornaUI();
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

		public IPresenterEvent Observer
		{
			get { return _observer; }
		}

		private void InitializeEvents()
		{
			BilancioGruppoForm.ModificaButton.Click += ModificaButton_Click;
			BilancioGruppoForm.ProdottiButton.Click += ProdottiButton_Click;
			BilancioGruppoForm.MembriListBox.Click += MembriListBox_Click;
			BilancioGruppoForm.FormClosing += BilancioGruppoForm_FormClosing;
		}

		public void AggiornaUI()
		{
			BilancioGruppoForm.GruppoLabel.Text = Gruppo.Nome;
			BilancioGruppoForm.PictureBox.Load(Gruppo.Foto);
			BilancioGruppoForm.BilancioLabel.Text = Utente.CalcolaBilancio(Gruppo).ToString("€ 0.00");
			BilancioGruppoForm.MembriListBox.DataSource = Gruppo.MembriGruppo;
			BilancioGruppoForm.MembriListBox.DisplayMember = "Mail";
			BilancioGruppoForm.DataGridView.DataSource = Gruppo.SpeseGruppo.Spese;
			BilancioGruppoForm.ModificaButton.Enabled = BilancioGruppoForm.DataGridView.RowCount != 0;
		}

		private void MembriListBox_Click(object sender, EventArgs e)
		{
			AmicoForm amicoForm = new AmicoForm();
			new AmicoFormPresenter(amicoForm, Utente, (Utente)BilancioGruppoForm.MembriListBox.SelectedItem);
			amicoForm.ShowDialog();
		}

		private void ModificaButton_Click(object sender, EventArgs e)
		{
			SpesaForm spesaForm = new SpesaForm();
			Spesa spesa = (Spesa)BilancioGruppoForm.DataGridView.CurrentRow.DataBoundItem;
			new SpesaFormPresenter(spesaForm, Utente, this, spesa);
			spesaForm.ShowDialog();
		}

		private void ProdottiButton_Click(object sender, EventArgs e)
		{
			ProdottiForm prodottiForm = new ProdottiForm();
			new ProdottiFormPresenter(prodottiForm, Gruppo);
			prodottiForm.ShowDialog();
		}

		void BilancioGruppoForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Observer.AggiornaUI();
		}
	}
}