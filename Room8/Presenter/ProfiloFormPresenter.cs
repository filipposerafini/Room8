﻿using System;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class ProfiloFormPresenter
	{
		ProfiloForm _profiloForm;
		Utente _utente;

		public ProfiloFormPresenter(ProfiloForm profiloForm, Utente utente)
		{
			this._profiloForm = profiloForm;
			this._utente = utente;

			InitializeEvents();
			InitializeUI();
		}

		public ProfiloForm ProfiloForm
		{
			get { return _profiloForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		private void InitializeEvents()
		{
			ProfiloForm.ConfermaButton.Click += ConfermaButton_Click;
			ProfiloForm.FotoButton.Click += FotoButton_Click;
		}

		void InitializeUI()
		{
			ProfiloForm.NomeTextBox.Text = Utente.Nome;
			ProfiloForm.CognomeTextBox.Text = Utente.Cognome;
			ProfiloForm.MailTextBox.Text = Utente.Mail;
			ProfiloForm.TelefonoTextBox.Text = Utente.Telefono;
			ProfiloForm.PictureBox.ImageLocation = Utente.Foto;
		}

		void ConfermaButton_Click(object sender, System.EventArgs e)
		{
			ProfiloForm.ErrorProvider.Clear();
			try
			{
				Utente.Nome = ProfiloForm.NomeTextBox.Text;
				Utente.Cognome = ProfiloForm.CognomeTextBox.Text;
				Utente.Mail = ProfiloForm.MailTextBox.Text;
				Utente.Telefono = ProfiloForm.TelefonoTextBox.Text;
				Utente.Foto = ProfiloForm.PictureBox.ImageLocation;

				if (!string.IsNullOrEmpty(ProfiloForm.NuovaPassword.Text))
				{
					if (!ProfiloForm.VecchiaPassword.Text.Equals(Utente.Password))
						throw new ArgumentException("La vecchia password non corrisponde", "vecchia");
					if (!ProfiloForm.NuovaPassword.Text.Equals(ProfiloForm.ConfermaPassword.Text))
						throw new ArgumentException("Le password non corrispondono", "conferma");
					Utente.Password = ProfiloForm.NuovaPassword.Text;
				}

				ProfiloForm.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "mail":
						control = ProfiloForm.MailTextBox;
						break;
					case "vecchia" :
						control = ProfiloForm.VecchiaPassword;
						break;
					case "password":
						control = ProfiloForm.NuovaPassword;
						break;
					case "conferma":
						control = ProfiloForm.ConfermaPassword;
						break;
					case "nome":
						control = ProfiloForm.NomeTextBox;
						break;
					case "cognome":
						control = ProfiloForm.CognomeTextBox;
						break;
					case "telefono":
						control = ProfiloForm.TelefonoTextBox;
						break;
					case "foto":
						control = ProfiloForm.FileLabel;
						break;
					default:
						control = ProfiloForm.ConfermaButton;
						break;
				}
				ProfiloForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}
		void FotoButton_Click(object sender, System.EventArgs e)
		{
			ProfiloForm.ErrorProvider.Clear();
			if (ProfiloForm.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string foto = ProfiloForm.OpenFileDialog.FileName;
				ProfiloForm.FileLabel.Text = foto.Substring(foto.LastIndexOf('/') + 1);
				ProfiloForm.PictureBox.ImageLocation = foto;
			}
		}
	}
}