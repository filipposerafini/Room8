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
			SaldoForm.EliminaButton.Click += EliminaButton_Click;
            SaldoForm.DaComboBox.SelectedIndexChanged += DaComboBox_SelectIndexChanged;
            SaldoForm.AComboBox.SelectedIndexChanged += AComboBox_SelectIndexChanged;
        }

		private void InitalizeUI()
		{
			SaldoForm.EliminaButton.Hide();
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
				SaldoForm.EliminaButton.Show();
				SaldoForm.DaComboBox.SelectedItem = Saldo.Sorgente;
				SaldoForm.AComboBox.SelectedItem = Saldo.Destinazione;
				SaldoForm.NumericUpDown.Value = Saldo.Importo;
				SaldoForm.DateTimePicker.Value = Saldo.Data;
			}
			SaldoForm.APictureBox.Load((SaldoForm.AComboBox.SelectedItem as Utente).Foto);
			SaldoForm.DaPictureBox.Load((SaldoForm.DaComboBox.SelectedItem as Utente).Foto);
		}

        private void DaComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
			SaldoForm.DaPictureBox.Load((SaldoForm.DaComboBox.SelectedItem as Utente).Foto);
        }

        private void AComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
			SaldoForm.APictureBox.Load((SaldoForm.AComboBox.SelectedItem as Utente).Foto);
        }

		void EliminaButton_Click(object sender, EventArgs e)
		{
			Saldo.RimuoviMovimentoDiDenaro();
			Observer.AggiornaUI();
			SaldoForm.DialogResult = DialogResult.OK;
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
                    case "importo" :
                        control = SaldoForm.NumericUpDown;
                        break;
                    case "data" :
                        control = SaldoForm.DateTimePicker;
                        break;
                    default:
                        control = SaldoForm.ConfermaButton;
						SaldoForm.ErrorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleLeft);
						break;
                }
				SaldoForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
				Saldo = null;
			}
        }
    }
}

