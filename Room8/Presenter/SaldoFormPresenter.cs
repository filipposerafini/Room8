﻿using System;
using Room8.View;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Room8
{
    public class SaldoFormPresenter
    {
        private readonly SaldoForm _saldoForm;
        private readonly Utente _utente;
		private Saldo _saldo;
        private readonly IPresenterEvent _observer;

        public SaldoFormPresenter(SaldoForm saldoForm, Utente utente, IPresenterEvent observer, Saldo saldo)
        {
            _saldoForm = saldoForm;
            _utente = utente;
            _observer = observer;
			_saldo = saldo;
			InitializeEvents();
			InitalizeUI();
		}

        public SaldoForm SaldoForm
        {
            get { return _saldoForm; }
        }

        public Utente Utente
        {
            get { return _utente; }
	    }

		public Saldo Saldo
		{
			get { return _saldo; }
			set { _saldo = value; }
		}

		public IPresenterEvent Observer
		{
			get { return _observer; }
		}

        private void InitializeEvents()
        {
            SaldoForm.ConfermaButton.Click += ConfermaButton_Click;
            SaldoForm.DaComboBox.SelectedIndexChanged += DaComboBox_SelectIndexChanged;
            SaldoForm.AComboBox.SelectedIndexChanged += AComboBox_SelectIndexChanged;
        }

		private void InitalizeUI()
		{
			List<Utente> utenti = Utente.Amici();
			utenti.Add(Utente);
			SaldoForm.DaComboBox.DataSource = utenti;
			SaldoForm.DaComboBox.DisplayMember = "Nome";
			utenti = Utente.Amici();
			utenti.Add(Utente);
			SaldoForm.AComboBox.DataSource = utenti;
			SaldoForm.AComboBox.DisplayMember = "Nome";
			if (Saldo != null)
			{
				SaldoForm.DaComboBox.SelectedItem = Saldo.Sorgente;
				SaldoForm.AComboBox.SelectedItem = Saldo.Destinazione;
				SaldoForm.NumericUpDown.Value = Saldo.Importo;
				SaldoForm.DateTimePicker.Value = Saldo.Data;
			}
			SaldoForm.APictureBox.ImageLocation = (SaldoForm.AComboBox.SelectedItem as Utente).Foto;
			SaldoForm.DaPictureBox.ImageLocation = (SaldoForm.DaComboBox.SelectedItem as Utente).Foto;
		}

        private void DaComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
            SaldoForm.DaPictureBox.ImageLocation = (SaldoForm.DaComboBox.SelectedItem as Utente).Foto;
        }

        private void AComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
            SaldoForm.APictureBox.ImageLocation = (SaldoForm.AComboBox.SelectedItem as Utente).Foto;
        }

        private void ConfermaButton_Click(object sender, EventArgs e)
        {
            SaldoForm.ErrorProvider.Clear();
            try
            {
				if (Saldo != null)
				{
					Saldo.Sorgente = (Utente)SaldoForm.DaComboBox.SelectedItem;
					Saldo.Destinazione = (Utente)SaldoForm.AComboBox.SelectedItem;
					Saldo.Importo = SaldoForm.NumericUpDown.Value;
					Saldo.Data = SaldoForm.DateTimePicker.Value;
				}
				else
				{
					Saldo = new Saldo((Utente)SaldoForm.DaComboBox.SelectedItem, (Utente)SaldoForm.AComboBox.SelectedItem,
									  SaldoForm.NumericUpDown.Value, SaldoForm.DateTimePicker.Value);
					Saldo.AggiungiMovimentoDiDenaro();
				}
                Observer.AggiornaUI();
                SaldoForm.Close();
            }
            catch (ArgumentException ae)
            {
                Control control;
                switch (ae.ParamName)
                {
                    case "sorgente" : 
                        control = SaldoForm.DaComboBox;
                        break;
                    case "destinazione" :
                        control = SaldoForm.AComboBox;
                        break;
                    case "importo" :
                        control = SaldoForm.NumericUpDown;
                        break;
                    case "data" :
                        control = SaldoForm.DateTimePicker;
                        break;
                    default:
                        control = SaldoForm.ConfermaButton;
                        break;
                }
                SaldoForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
            }
        }
    }
}

