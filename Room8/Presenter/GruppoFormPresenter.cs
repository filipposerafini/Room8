using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Room8.View;
using System.Linq;

namespace Room8
{
	class GruppoFormPresenter
	{
		private readonly GruppoForm _gruppoForm;
		private readonly Utente _utente;
		private Gruppo _gruppo;
		private readonly IPresenterEvent _observer;
		private List<Button> _controls;
		private List<TextBox> _mails;

		public GruppoFormPresenter(GruppoForm gruppoForm, Utente utente, Gruppo gruppo, IPresenterEvent observer)
		{
			_gruppoForm = gruppoForm;
			_utente = utente;
			_gruppo = gruppo;
			_observer = observer;
			_controls = new List<Button>();
			_mails = new List<TextBox>();
			InitializeEvents();
			InitializeUI();
		}

		public GruppoForm GruppoForm
		{
			get { return _gruppoForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }
			set { _gruppo = value; }
		}

		public IPresenterEvent Observer
		{
			get { return _observer; }
		}

		public List<Button> Controls
		{
			get { return _controls; }
		}

		public List<TextBox> Mails
		{
			get { return _mails; }
		}

		private void InitializeEvents()
		{
			GruppoForm.FotoButton.Click += FotoButton_Click;
			GruppoForm.AggiungiPersonaLinkLabel.Click += AggiungiPersonaLinkLabel_Click;
			GruppoForm.ConfermaButton.Click += ConfermaButton_Click;
			GruppoForm.EliminaButton.Click += EliminaButton_Click;
		}

		private void InitializeUI()
		{
			GruppoForm.EliminaButton.Hide();
			if (Gruppo != null)
			{
				GruppoForm.EliminaButton.Show();
				GruppoForm.NomeGruppoTextBox.Text = Gruppo.Nome;
				GruppoForm.PictureBox.Load(Gruppo.Foto);
				GruppoForm.FileLabel.Text = Gruppo.Foto.Substring(Gruppo.Foto.LastIndexOf('\\') + 1);
				foreach (var utente in Gruppo.MembriGruppo)
					if (!utente.Equals(Utente))
						AggiungiRiga(utente.Mail);
			}
		}

		private void AggiungiRiga(string mail)
		{
			Label mailLabel = new Label();
			mailLabel.AutoSize = true;
			mailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			mailLabel.Location = new System.Drawing.Point(3, 0);
			mailLabel.Name = "_mailLabel";
			mailLabel.Size = new System.Drawing.Size(78, 38);
			mailLabel.TabIndex = 2;
			mailLabel.Text = "E-mail";
			mailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			TextBox mailTextBox = new TextBox();
			mailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			mailTextBox.Location = new System.Drawing.Point(87, 9);
			mailTextBox.Name = "_mailTextBox";
			mailTextBox.Text = mail;
			mailTextBox.Size = new System.Drawing.Size(189, 20);
			mailTextBox.TabIndex = 1;
			if (!mail.Equals(""))
				mailTextBox.Enabled = false;

			Button removeButton = new Button();
			removeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			removeButton.Location = new System.Drawing.Point(298, 9);
			removeButton.Name = "_removeButton";
			removeButton.Size = new System.Drawing.Size(27, 20);
			removeButton.TabIndex = 0;
			removeButton.Text = "X";
			removeButton.UseVisualStyleBackColor = true;
			removeButton.Click += RemoveButton_Click;

			GruppoForm.MembriTable.Controls.Add(mailLabel, 0, GruppoForm.MembriTable.RowStyles.Count - 1);
			GruppoForm.MembriTable.Controls.Add(mailTextBox, 1, GruppoForm.MembriTable.RowStyles.Count - 1);
			GruppoForm.MembriTable.Controls.Add(removeButton, 2, GruppoForm.MembriTable.RowStyles.Count - 1);
            GruppoForm.MembriTable.Height += 40;
			GruppoForm.MembriTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
			GruppoForm.MembriTable.RowCount++;
			Controls.Add(removeButton);
			Mails.Add(mailTextBox);
		}

		private void RimuoviRiga(int index)
		{
			if (index >= GruppoForm.MembriTable.RowCount)
				return;
			for (int i = 0; i < GruppoForm.MembriTable.ColumnCount; i++)
			{
				var control = GruppoForm.MembriTable.GetControlFromPosition(i, index);
				GruppoForm.MembriTable.Controls.Remove(control);
			}
			for (int i = index + 1; i < GruppoForm.MembriTable.RowCount; i++)
			{
				for (int j = 0; j < GruppoForm.MembriTable.ColumnCount; j++)
				{
					var control = GruppoForm.MembriTable.GetControlFromPosition(j, i);
					if (control != null)
						GruppoForm.MembriTable.SetRow(control, i - 1);
				}
			}
			GruppoForm.MembriTable.RowStyles.RemoveAt(GruppoForm.MembriTable.RowCount - 1);
			GruppoForm.MembriTable.RowCount--;
			GruppoForm.MembriTable.Height -= 40;
		}

        private void FotoButton_Click(object sender, EventArgs e)
		{
			GruppoForm.ErrorProvider.Clear();
            try
            {
                if (GruppoForm.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string foto = GruppoForm.OpenFileDialog.FileName;
                    GruppoForm.FileLabel.Text = foto.Substring(foto.LastIndexOf('\\') + 1);
                    GruppoForm.PictureBox.Load(foto);
                }
            }
            catch (ArgumentException)
            {
                GruppoForm.ErrorProvider.SetIconAlignment(GruppoForm.FotoButton, ErrorIconAlignment.MiddleLeft);
                GruppoForm.ErrorProvider.SetError(GruppoForm.FotoButton, "Seleziona un'immagine valida");
            }
		}

		private void AggiungiPersonaLinkLabel_Click(object sender, EventArgs e)
		{
			GruppoForm.ErrorProvider.Clear();
			try
			{
				if (Gruppo == null)
					Gruppo = new Gruppo(GruppoForm.NomeGruppoTextBox.Text);
				AggiungiRiga("");
			}
			catch (ArgumentException ae)
			{
				GruppoForm.ErrorProvider.SetError(GruppoForm.NomeGruppoTextBox, string.IsNullOrEmpty(ae.ParamName) ?
                    ae.Message : ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			GruppoForm.ErrorProvider.Clear();
			int index = Controls.IndexOf((Button)sender);
			if (Mails[index].Enabled == false &&
				GestoreUtenti.Instance.GetUtente(Mails[index].Text).CalcolaBilancio(Gruppo) != 0)
				GruppoForm.ErrorProvider.SetError(GruppoForm.AggiungiPersonaLinkLabel, "L'utente deve essere in pari con il gruppo");
			else
			{
				RimuoviRiga(index);
				Mails.RemoveAt(index);
				Controls.RemoveAt(index);
			}
		}

		void EliminaButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (Mails.Count > 0)
					throw new ArgumentException("Devi prima rimuovere tutti i membri");
				while (Gruppo.MembriGruppo.Count > 0)
					Gruppo.RimuoviMembro(Gruppo.MembriGruppo[0].Mail);
				Observer.AggiornaUI();
				GruppoForm.DialogResult = DialogResult.OK;
			}
			catch (ArgumentException ae)
			{
				GruppoForm.ErrorProvider.SetError(GruppoForm.EliminaButton, ae.Message);
			}
		}

		private void ConfermaButton_Click(object sender, EventArgs e)
		{
			GruppoForm.ErrorProvider.Clear();
			try
			{
				if (Mails.Count == 0)
					throw new ArgumentException("Inserisci almeno un'altro utente", "membro");
				Gruppo.Nome = GruppoForm.NomeGruppoTextBox.Text;
				Gruppo.Foto = GruppoForm.PictureBox.ImageLocation;
				int i;
				for (i = 0; i < Gruppo.MembriGruppo.Count; i++)
				{
					int j;
					for (j = 0; j < Mails.Count; j++)
					{
						if (Gruppo.MembriGruppo[i].Mail.Equals(Mails[j].Text))
							break;
					}
					if (j < Mails.Count)
						continue;
					Gruppo.RimuoviMembro(Gruppo.MembriGruppo[i].Mail);
					i--;
				}

				for (int j = i; j < Mails.Count; j++)
				{
					if (Mails[j].Text.Equals(""))
						throw new ArgumentException("Inserisci una mail", "membro");
					Utente utente = GestoreUtenti.Instance.GetUtente(Mails[j].Text);
					if (utente == null)
						throw new ArgumentException("Utente " + Mails[j].Text + " inesistente", "membro");
					Gruppo.AggiungiMembro(utente);
				}
				Gruppo.AggiungiMembro(Utente);
				Observer.AggiornaUI();
				GruppoForm.DialogResult = DialogResult.OK;
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "nome" :
						control = GruppoForm.NomeGruppoTextBox;
						break;
					case "membro" :
						control = GruppoForm.AggiungiPersonaLinkLabel;
						break;
                    case "file":
                        control = GruppoForm.FileLabel;
                        break;
					default:
                        GruppoForm.ErrorProvider.SetIconAlignment(GruppoForm.ConfermaButton, ErrorIconAlignment.MiddleLeft);
						control = GruppoForm.ConfermaButton;
						break;
				}
                GruppoForm.ErrorProvider.SetError(control, string.IsNullOrEmpty(ae.ParamName) ? 
                    ae.Message : ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}
	}
}