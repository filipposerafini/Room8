using System;
using System.Drawing;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class AmicoFormPresenter : IPresenterEvent
	{
		private readonly AmicoForm _amicoForm; 
		private readonly Utente _utente;
		private readonly Utente _amico;
        private IPresenterEvent _observer;

		public AmicoFormPresenter(AmicoForm amicoForm, Utente utente, Utente amico)
		{
			_amicoForm = amicoForm;
			_utente = utente;
			_amico = amico;
			AmicoForm.ModificaButton.Click += ModificaButton_Click;
			AggiornaUI();
		}

        public void Attach(IPresenterEvent observer)
        {
            _observer = observer;
        }

		public AmicoForm AmicoForm
		{
			get { return _amicoForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		public Utente Amico
		{
			get { return _amico; }
		}

        public IPresenterEvent Observer
        {
            get { return _observer; }
        }

		public void AggiornaUI()
		{
			AmicoForm.NomeAmicoLabel.Text = Amico.Nome + " " + Amico.Cognome;
			AmicoForm.PictureBox.Load(Amico.Foto);
			decimal bilancio = Utente.CalcolaSituazione(Amico);
			AmicoForm.ImportoLabel.Text = Math.Abs(bilancio).ToString("€ 0.00");
			if (bilancio > 0)
			{
				AmicoForm.BilancioLabel.Text = "Devi dare";
				AmicoForm.ImportoLabel.ForeColor = Color.Red;
			}
			else if (bilancio < 0)
			{
				AmicoForm.BilancioLabel.Text = "Devi ricevere";
				AmicoForm.ImportoLabel.ForeColor = Color.Green;
			}
			else
			{
				AmicoForm.BilancioLabel.Text = "In pari";
				AmicoForm.ImportoLabel.ForeColor = Color.Green;
				AmicoForm.ImportoLabel.Text = ":D";
			}
			AmicoForm.DataGridView.DataSource = Utente.MovimentiDiDenaro.FindAll
				(m => m.Sorgente.Equals(Amico) || m.Destinazione.Equals(Amico));
			AmicoForm.ModificaButton.Enabled = AmicoForm.DataGridView.RowCount != 0;
		}

		private void AggiornaBilancio(decimal value)
		{
			if (value == 0)
			{
				AmicoForm.BilancioLabel.Text = "In pari";
				AmicoForm.BilancioLabel.ForeColor = Color.Green;
				AmicoForm.ImportoLabel.Text = "";
			}
			else if (value > 0)
			{
				AmicoForm.BilancioLabel.Text = "Devi dare:";
				AmicoForm.ImportoLabel.Text = value.ToString();
			}
			else
			{
				AmicoForm.BilancioLabel.Text = "Devi ricevere:";
				AmicoForm.BilancioLabel.ForeColor = Color.Green;
				AmicoForm.ImportoLabel.Text = value.ToString("€ 0.00");
			}
		}
		
		void ModificaButton_Click(object sender, EventArgs e)
		{
			MovimentoDiDenaro movimento = (MovimentoDiDenaro)AmicoForm.DataGridView.CurrentRow.DataBoundItem;
			if (movimento is Movimento)
			{
				SpesaForm spesaForm = new SpesaForm();
				SpesaFormPresenter spesaFormPresenter = new SpesaFormPresenter(spesaForm, Utente, (movimento as Movimento).Spesa);
                spesaFormPresenter.Attach(this);
                if (spesaForm.ShowDialog() == DialogResult.OK)
                    Observer.AggiornaUI();
			}
			else if (movimento is Saldo)
			{
				SaldoForm saldoForm = new SaldoForm();
                SaldoFormPresenter saldoFormPresenter = new SaldoFormPresenter(saldoForm, Utente, (movimento as Saldo));
                saldoFormPresenter.Attach(this);
                if (saldoForm.ShowDialog() == DialogResult.OK)
                    Observer.AggiornaUI();
			}
		}
	}
}