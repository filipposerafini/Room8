using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class ProdottiFormPresenter
	{
		private readonly ProdottiForm _prodottiForm;
		private readonly Gruppo _gruppo;

		public ProdottiFormPresenter(ProdottiForm prodottiForm, Gruppo gruppo)
		{
			_prodottiForm = prodottiForm;
			_gruppo = gruppo;
			InitializeEvents();
			AggiornaUI();
		}

		public ProdottiForm ProdottiForm
		{
			get { return _prodottiForm; }
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }
		}

		void InitializeEvents()
		{
			ProdottiForm.RimuoviButton.Click += RimuoviButton_Click;
			ProdottiForm.AggiungiButton.Click += AggiungiButton_Click;
		}

		void AggiornaUI()
		{
			ProdottiForm.DataGridView.DataSource = Gruppo.DaComprare;
		}

		void AggiungiButton_Click(object sender, EventArgs e)
		{
			ProdottiForm.ErrorProvider.Clear();
			try
			{
				Prodotto prodotto = new Prodotto(
					ProdottiForm.ProdottoTextBox.Text,
					(int)ProdottiForm.NumericUpDown.Value);
				Gruppo.AggiungiProdotto(prodotto);
				ProdottiForm.ProdottoTextBox.Text = "";
				ProdottiForm.NumericUpDown.Value = 0;
				AggiornaUI();
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "nome" :
						control = ProdottiForm.ProdottoTextBox;
						break;
					case "quantita" :
						control = ProdottiForm.NumericUpDown;
						break;
					case "rimuovi" :
						control = ProdottiForm.RimuoviButton;
						break;
					default:
						control = ProdottiForm.AggiungiButton;
						ProdottiForm.ErrorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleLeft);
						break;
				}
				ProdottiForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}

		void RimuoviButton_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in ProdottiForm.DataGridView.SelectedRows)
				Gruppo.RimuoviProdotto((Prodotto)row.DataBoundItem);
			AggiornaUI();
		}
	}
}