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
		private readonly Saldo _daModificare;
        private readonly IPresenterEvent _observer;

        public SaldoFormPresenter(SaldoForm saldoForm, Utente utente, IPresenterEvent observer, Saldo saldo)
        {
            _saldoForm = saldoForm;
            _utente = utente;
            _observer = observer;
			_daModificare = saldo;
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

		public Saldo DaModificare
		{
			get { return _daModificare; }
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
            SaldoForm.DaComboBox.SelectedItem = Utente;
			utenti = Utente.Amici();
			utenti.Add(Utente);
			SaldoForm.AComboBox.DataSource = utenti;
			SaldoForm.AComboBox.DisplayMember = "Nome";
			if (DaModificare != null)
			{
                SaldoForm.ConfermaButton.Text = "Salva";
				SaldoForm.EliminaButton.Show();
				SaldoForm.DaComboBox.SelectedItem = DaModificare.Sorgente;
				SaldoForm.AComboBox.SelectedItem = DaModificare.Destinazione;
				SaldoForm.NumericUpDown.Value = DaModificare.Importo;
				SaldoForm.DateTimePicker.Value = DaModificare.Data;
			}
			SaldoForm.APictureBox.Load((SaldoForm.AComboBox.SelectedItem as Utente).Foto);
			SaldoForm.DaPictureBox.Load((SaldoForm.DaComboBox.SelectedItem as Utente).Foto);
		}

        private void DaComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
			SaldoForm.DaPictureBox.Load((SaldoForm.DaComboBox.SelectedItem as Utente).Foto);
            if (SaldoForm.AComboBox.Items.Count != 0 && (SaldoForm.DaComboBox.SelectedItem as Utente).CalcolaSituazione((Utente)SaldoForm.AComboBox.SelectedItem) > 0)
                SaldoForm.NumericUpDown.Value = (SaldoForm.DaComboBox.SelectedItem as Utente).CalcolaSituazione((Utente)SaldoForm.AComboBox.SelectedItem);
            else
                SaldoForm.NumericUpDown.Value = 0;
        }

        private void AComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
			SaldoForm.APictureBox.Load((SaldoForm.AComboBox.SelectedItem as Utente).Foto);
            if ((SaldoForm.DaComboBox.SelectedItem as Utente).CalcolaSituazione((Utente)SaldoForm.AComboBox.SelectedItem) > 0)
                SaldoForm.NumericUpDown.Value = (SaldoForm.DaComboBox.SelectedItem as Utente).CalcolaSituazione((Utente)SaldoForm.AComboBox.SelectedItem);
            else
                SaldoForm.NumericUpDown.Value = 0;
        }

		void EliminaButton_Click(object sender, EventArgs e)
		{
			DaModificare.RimuoviMovimentoDiDenaro();
			Observer.AggiornaUI();
			SaldoForm.DialogResult = DialogResult.OK;
		}

		private void ConfermaButton_Click(object sender, EventArgs e)
        {
            SaldoForm.ErrorProvider.Clear();
            try
            {
				Saldo saldo = new Saldo((Utente)SaldoForm.DaComboBox.SelectedItem, (Utente)SaldoForm.AComboBox.SelectedItem,
				                  SaldoForm.NumericUpDown.Value, SaldoForm.DateTimePicker.Value);
				saldo.AggiungiMovimentoDiDenaro();
				if (DaModificare != null)
					DaModificare.RimuoviMovimentoDiDenaro();
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
				SaldoForm.ErrorProvider.SetError(control, string.IsNullOrEmpty(ae.ParamName) ?
					ae.Message : ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
        }
    }
}

