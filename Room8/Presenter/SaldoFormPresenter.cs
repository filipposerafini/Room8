using System;
using Room8.View;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Room8
{
    public class SaldoFormPresenter
    {
        private SaldoForm _saldoForm;
        private readonly Utente _utente;
        private readonly Saldo _saldo;

        public SaldoFormPresenter(SaldoForm saldoForm, Utente utente)
        {
            this._saldoForm = saldoForm;
            this._utente = utente;
            this._saldo = new Saldo();
            InitializeEvents();

			List<Utente> utenti = utente.Amici();
			utenti.Add(utente);
			SaldoForm.DaComboBox.DataSource = utenti;
            SaldoForm.DaComboBox.DisplayMember = "Nome";
			utenti = utente.Amici();
			utenti.Add(utente);
			SaldoForm.AComboBox.DataSource = utenti;
            SaldoForm.AComboBox.DisplayMember = "Nome";
			//SaldoForm.DaComboBox.SelectedText = utente.Nome;

            SaldoForm.APictureBox.ImageLocation = (SaldoForm.AComboBox.SelectedItem as Utente).Foto;
            SaldoForm.DaPictureBox.ImageLocation = (SaldoForm.DaComboBox.SelectedItem as Utente).Foto;
        }

        public SaldoFormPresenter(SaldoForm saldoForm, Utente utente, Saldo daModificare)
        {
            this._saldoForm = saldoForm;
            this._utente = utente;
            this._saldo = new Saldo();
            InitializeEvents();

            SaldoForm.DaComboBox.DataSource = utente.Amici();
            SaldoForm.DaComboBox.DisplayMember = "Nome";
            SaldoForm.AComboBox.DataSource = utente.Amici();
            SaldoForm.AComboBox.DisplayMember = "Nome";

            SaldoForm.DaComboBox.SelectedItem = daModificare.Sorgente;
            SaldoForm.AComboBox.SelectedItem = daModificare.Destinazione;
            SaldoForm.NumericUpDown.Value = daModificare.Importo;
            SaldoForm.DateTimePicker.Value = daModificare.Data;   

            SaldoForm.DaPictureBox.ImageLocation = daModificare.Sorgente.Foto;
            SaldoForm.APictureBox.ImageLocation = daModificare.Destinazione.Foto;
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
        }

        private void InitializeEvents()
        {
            SaldoForm.ConfermaButton.Click += ConfermaButton_Click;
            SaldoForm.DaComboBox.SelectedIndexChanged += DaComboBox_SelectIndexChanged;
            SaldoForm.AComboBox.SelectedIndexChanged += AComboBox_SelectIndexChanged;
        }

		private void InitalizeCombo()
		{
			
		}

        void DaComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
            SaldoForm.DaPictureBox.ImageLocation = (SaldoForm.DaComboBox.SelectedItem as Utente).Foto;
        }

        void AComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
            SaldoForm.APictureBox.ImageLocation = (SaldoForm.AComboBox.SelectedItem as Utente).Foto;
        }

        void ConfermaButton_Click(object sender, EventArgs e)
        {
            SaldoForm.ErrorProvider.Clear();
            try
            {
                Saldo.Sorgente = (Utente)SaldoForm.DaComboBox.SelectedItem;
                Saldo.Destinazione = (Utente)SaldoForm.AComboBox.SelectedItem;
                Saldo.Importo = SaldoForm.NumericUpDown.Value;
                Saldo.Data = SaldoForm.DateTimePicker.Value;

                Saldo.AggiungiMovimentoDiDenaro();
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

