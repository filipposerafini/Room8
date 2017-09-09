using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class GruppoFormPresenter
	{
		private readonly GruppoForm _gruppoForm;
		private readonly Utente _utente;
		private Gruppo _gruppo;
		private Dictionary<TextBox, Button> _controls;

		public GruppoFormPresenter(GruppoForm creaGruppoForm, Utente utente, Gruppo gruppo)
		{
			this._gruppoForm = creaGruppoForm;
			this._utente = utente;
			this._gruppo = gruppo;
			this._controls = new Dictionary<TextBox, Button>();
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

		public Dictionary<TextBox, Button> Controls
		{
			get { return _controls; }
		}

		void InitializeEvents()
		{
			GruppoForm.FotoButton.Click += FotoButton_Click;
			GruppoForm.AggiungiPersonaLinkLabel.Click += AggiungiPersonaLinkLabel_Click;
			GruppoForm.ConfermaButton.Click += ConfermaButton_Click;
		}

		void InitializeUI()
		{
			GruppoForm.MailLabel.Text = Utente.Mail;
			if (Gruppo != null)
			{
				GruppoForm.NomeGruppoTextBox.Text = Gruppo.Nome;
				GruppoForm.PictureBox.ImageLocation = Gruppo.Foto;
				GruppoForm.FileLabel.Text = Gruppo.Foto.Substring(Gruppo.Foto.LastIndexOf('\\') + 1);
				foreach (var utente in Gruppo.MembriGruppo)
					if (!utente.Equals(Utente))
						AggiungiRiga(utente.Mail);
			}
		}

		void AggiungiRiga(string mail)
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

			Button removeButton = new Button();
			removeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			removeButton.Location = new System.Drawing.Point(298, 9);
			removeButton.Name = "_removeButton";
			removeButton.Size = new System.Drawing.Size(27, 20);
			removeButton.TabIndex = 0;
			removeButton.Text = "X";
			removeButton.UseVisualStyleBackColor = true;

			GruppoForm.MembriTable.Controls.Add(mailLabel, 0, GruppoForm.MembriTable.RowStyles.Count - 1);
			GruppoForm.MembriTable.Controls.Add(mailTextBox, 1, GruppoForm.MembriTable.RowStyles.Count - 1);
			GruppoForm.MembriTable.Controls.Add(removeButton, 2, GruppoForm.MembriTable.RowStyles.Count - 1);
            GruppoForm.MembriTable.Height = 40 * GruppoForm.MembriTable.RowStyles.Count - 2;
            GruppoForm.MembriTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
        }

        void FotoButton_Click(object sender, EventArgs e)
		{
			GruppoForm.ErrorProvider.Clear();
			if (GruppoForm.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				string foto = GruppoForm.OpenFileDialog.FileName;
				GruppoForm.FileLabel.Text = foto.Substring(foto.LastIndexOf('\\') + 1);
				GruppoForm.PictureBox.ImageLocation = foto;
			}
		}

		void AggiungiPersonaLinkLabel_Click(object sender, EventArgs e)
		{
			AggiungiRiga("");
		}

		void ConfermaButton_Click(object sender, EventArgs e)
		{
			if (Gruppo == null)
				Gruppo = new Gruppo(GruppoForm.NomeGruppoTextBox.Text);
			else
				Gruppo.Nome = GruppoForm.NomeGruppoTextBox.Text;
			Gruppo.Foto = GruppoForm.PictureBox.ImageLocation;
		}
	}
}