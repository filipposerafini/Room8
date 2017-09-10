using System;
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
			InitializeUI();
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

		void InitializeUI()
		{
			
		}

		void AggiungiButton_Click(object sender, EventArgs e)
		{

		}

		void RimuoviButton_Click(object sender, EventArgs e)
		{

		}
	}
}