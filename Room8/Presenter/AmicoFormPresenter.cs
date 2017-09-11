using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class AmicoFormPresenter : IPresenterEvent
	{
		private readonly AmicoForm _amicoForm; 
		private readonly Utente _utente;
		private readonly Utente _amico;

		public AmicoFormPresenter(AmicoForm amicoForm, Utente utente, Utente amico)
		{
			_amicoForm = amicoForm;
			_utente = utente;
			_amico = amico;
			AmicoForm.DataGridView.Click += DataGridView_Click;
			AggiornaUI();
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

		public void AggiornaUI()
		{
			AmicoForm.NomeAmicoLabel.Text = Amico.Nome + " " + Amico.Cognome;
			AmicoForm.PictureBox.ImageLocation = Amico.Foto;
			AmicoForm.BilancioLabel.Text = Utente.CalcolaSituazione(Amico).ToString("€ 0.00");
			AmicoForm.DataGridView.DataSource = Utente.MovimentiDiDenaro.FindAll
				(m => m.Sorgente.Equals(Amico) || m.Destinazione.Equals(Amico));
			AmicoForm.DataGridView.Enabled = AmicoForm.DataGridView.RowCount != 0;
		}

		void DataGridView_Click(object sender, EventArgs e)
		{
			MovimentoDiDenaro movimento = (MovimentoDiDenaro)AmicoForm.DataGridView.CurrentRow.DataBoundItem;
			if (movimento is Movimento)
			{
				SpesaForm spesaForm = new SpesaForm();
				new SpesaFormPresenter(spesaForm, Utente, this, (movimento as Movimento).Spesa);
				spesaForm.ShowDialog();
			}
			else if (movimento is Saldo)
			{
				SaldoForm saldoForm = new SaldoForm();
				new SaldoFormPresenter(saldoForm, Utente, this, (movimento as Saldo));
				saldoForm.ShowDialog();
			}
		}
	}
}