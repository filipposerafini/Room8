using System;
using System.Linq;
using Room8.View;

namespace Room8
{
	public class CommentoFormPresenter
	{
		private readonly CommentoForm _commentoForm;
		private readonly Spesa _spesa;
		private readonly Utente _utente;

		public CommentoFormPresenter(CommentoForm commentoForm, Spesa spesa, Utente utente)
		{
			_commentoForm = commentoForm;
			_spesa = spesa;
			_utente = utente;
			InitializeEvents();
			AggiornaUI();
		}

		public CommentoForm CommentoForm
		{
			get { return _commentoForm; }
		}

		public Spesa Spesa
		{
			get { return _spesa; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		private void InitializeEvents()
		{
			CommentoForm.CommentaButton.Click += CommentaButton_Click;
		}

		private void AggiornaUI()
		{
            CommentoForm.CommentiDataGridView.DataSource = Spesa.Commenti.ToList();
		}

		private void CommentaButton_Click(object sender, EventArgs e)
		{
			CommentoForm.ErrorProvider.Clear();
			try
			{
				Spesa.AggiungiCommento(new Commento(CommentoForm.CommentoTextBox.Text, Utente));
				AggiornaUI();
				CommentoForm.CommentoTextBox.Text = "";
			}
			catch (ArgumentException ae)
			{
				CommentoForm.ErrorProvider.SetError(CommentoForm.CommentoTextBox, ae.Message);
			}
		}
	}
}
