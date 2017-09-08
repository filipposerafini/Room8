using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	class PartiFormPresenter
	{
		private PartiForm _partiForm;
		private Spesa _spesa;
		private string _nomeMetodo;
		private Dictionary<Utente, Control> _dictionary;

		public PartiFormPresenter(PartiForm partiForm, Spesa spesa, string nomeMetodo)
		{
			this._partiForm = partiForm;
			this._spesa = spesa;
			this._nomeMetodo = nomeMetodo;
			this._dictionary = new Dictionary<Utente, Control>();
			InitializeEvents();
			InitializeParti();
		}

		public PartiForm PartiForm
		{
			get { return _partiForm; }
		}

		public Spesa Spesa
		{
			get { return _spesa; }
		}

		public string NomeMetodo
		{
			get { return _nomeMetodo; }
		}

		public Dictionary<Utente, Control> Dictionary
		{
			get { return _dictionary; }
		}

		void InitializeEvents()
		{
			PartiForm.ConfermaButton.Click += ConfermaButton_Click;
		}

		void InitializeParti()
		{
			PartiForm.PartiLabel.Text = "Divisione " + NomeMetodo;
			TableLayoutPanel partiTableLayoutPanel = new TableLayoutPanel();
			partiTableLayoutPanel.Dock = DockStyle.Top;
			partiTableLayoutPanel.ColumnCount = 1;
			partiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			partiTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			partiTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			partiTableLayoutPanel.Name = "_partiTableLayoutPanel";
			partiTableLayoutPanel.RowCount = 1;
            partiTableLayoutPanel.Height = 40;
			partiTableLayoutPanel.TabIndex = 2;

			for (int i = 0; i < Spesa.SpeseGruppo.Gruppo.MembriGruppo.Utenti.Count; i++)
			{
				NumericUpDown numericUpDown = new NumericUpDown();
				numericUpDown.DecimalPlaces = 2;
				numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
				numericUpDown.Location = new System.Drawing.Point(13, 10);
				numericUpDown.Name = "_numericUpDown" + i;
				numericUpDown.TabIndex = 1;

				Label utenteLabel = new Label();
				utenteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
				utenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				utenteLabel.Location = new System.Drawing.Point(0, 0);
				utenteLabel.Name = "_utenteLabel" + i;
				utenteLabel.TabIndex = 0;
				utenteLabel.Text = Spesa.SpeseGruppo.Gruppo.MembriGruppo.Utenti[i].Nome + " " + Spesa.SpeseGruppo.Gruppo.MembriGruppo.Utenti[i].Cognome;
				utenteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

				SplitContainer splitContainer = new SplitContainer();
				splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
				splitContainer.Location = new System.Drawing.Point(3, 3);
				splitContainer.Name = "_splitContainer" + i;
				splitContainer.IsSplitterFixed = true;
				// 
				// _splitContainer.Panel1
				// 
				splitContainer.Panel1.Controls.Add(utenteLabel);
				// 
				// _splitContainer.Panel2
				// 
				splitContainer.Panel2.Controls.Add(numericUpDown);
				splitContainer.SplitterDistance = 75;
				splitContainer.TabIndex = 0;


				partiTableLayoutPanel.Height = 40 + 40*i;
				partiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
				partiTableLayoutPanel.Controls.Add(splitContainer, 0, i);

				Dictionary.Add(Spesa.SpeseGruppo.Gruppo.MembriGruppo.Utenti[i], numericUpDown);
			}

			PartiForm.ScrollPanel.Controls.Add(partiTableLayoutPanel);
		}

		void ConfermaButton_Click(object sender, EventArgs e)
		{
			PartiForm.ErrorProvider.Clear();
			try
			{
				foreach (var utente in Dictionary.Keys)
				{
					Spesa.Parti.ImpostaParte(utente, (Dictionary[utente] as NumericUpDown).Value);
				}
				Spesa.MetodoDivisione.ControllaParti(Spesa.Parti, Spesa.Importo);
				PartiForm.DialogResult = DialogResult.OK;
			}
			catch (ArgumentException ae)
			{
				PartiForm.ErrorProvider.SetError(PartiForm.ConfermaButton, ae.Message);
			}
		}
	}
}