﻿using System;
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
			this._commentoForm = commentoForm;
			this._spesa = spesa;
			this._utente = utente;
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

		void InitializeEvents()
		{
			CommentoForm.CommentaButton.Click += CommentaButton_Click;
		}

		void AggiornaUI()
		{
			CommentoForm.CommentiListBox.Items.Clear();
			foreach (var commento in Spesa.Commenti)
				CommentoForm.CommentiListBox.Items.Add(commento.Autore.Nome + ": " + commento.Testo);
		}

		void CommentaButton_Click(object sender, EventArgs e)
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
