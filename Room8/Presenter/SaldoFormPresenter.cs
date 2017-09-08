using System;
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
        private readonly IPresenterEvent _observer;

        public SaldoFormPresenter(SaldoForm saldoForm, Utente utente, IPresenterEvent observer, Saldo daModificare)
        {
            this._saldoForm = saldoForm;
            this._utente = utente;
            this._observer = observer;
			InitializeEvents();
			InitalizeUI(daModificare);
		}

        public SaldoForm SaldoForm
        {
            get { return _saldoForm; }
        }

        public Utente Utente
        {
            get { return _utente; }
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

		private void InitalizeUI(Saldo saldo)
		{
			List<Utente> utenti = Utente.Amici();
			utenti.Add(Utente);
			SaldoForm.DaComboBox.DataSource = utenti;
			SaldoForm.DaComboBox.DisplayMember = "Nome";
			utenti = Utente.Amici();
			utenti.Add(Utente);
			SaldoForm.AComboBox.DataSource = utenti;
			SaldoForm.AComboBox.DisplayMember = "Nome";
			if (saldo != null)
			{
				SaldoForm.DaComboBox.SelectedItem = saldo.Sorgente;
				SaldoForm.AComboBox.SelectedItem = saldo.Destinazione;
				SaldoForm.NumericUpDown.Value = saldo.Importo;
				SaldoForm.DateTimePicker.Value = saldo.Data;
			}
			SaldoForm.APictureBox.ImageLocation = (SaldoForm.AComboBox.SelectedItem as Utente).Foto;
			SaldoForm.DaPictureBox.ImageLocation = (SaldoForm.DaComboBox.SelectedItem as Utente).Foto;
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
                Utente sorgente = (Utente)SaldoForm.DaComboBox.SelectedItem;
                Utente destinazione = (Utente)SaldoForm.AComboBox.SelectedItem;
                decimal importo = SaldoForm.NumericUpDown.Value;
                DateTime data = SaldoForm.DateTimePicker.Value;
                Saldo saldo = new Saldo(sorgente,destinazione,importo,data);

                saldo.AggiungiMovimentoDiDenaro();
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

