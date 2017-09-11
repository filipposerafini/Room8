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
			_partiForm = partiForm;
			_spesa = spesa;
			_nomeMetodo = nomeMetodo;
			_dictionary = new Dictionary<Utente, Control>();
			InitializeEvents();
			InitializeUI();
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

		void InitializeUI()
		{
			PartiForm.PartiLabel.Text = "Divisione " + NomeMetodo;
			TableLayoutPanel tablePanel = new TableLayoutPanel();
			tablePanel.Dock = DockStyle.Top;
			tablePanel.ColumnCount = 1;
			tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			tablePanel.Location = new System.Drawing.Point(0, 0);
			tablePanel.Margin = new System.Windows.Forms.Padding(0);
			tablePanel.Name = "_partiTableLayoutPanel";
			tablePanel.RowCount = 1;
            tablePanel.Height = 40;
			tablePanel.TabIndex = 2;

            for (int i = 0; i < Spesa.SpeseGruppo.Gruppo.MembriGruppo.Count; i++)
			{
				AggiungiRiga(tablePanel, i);
			}

			PartiForm.ScrollPanel.Controls.Add(tablePanel);
		}

		private void AggiungiRiga(TableLayoutPanel panel, int index)
		{
			NumericUpDown numericUpDown = new NumericUpDown();
			numericUpDown.DecimalPlaces = 2;
			numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
			numericUpDown.Location = new System.Drawing.Point(13, 10);
			numericUpDown.Name = "_numericUpDown";
			numericUpDown.TabIndex = 1;
			numericUpDown.Value = Spesa.Parti.Divisione[Spesa.SpeseGruppo.Gruppo.MembriGruppo[index]];

			Label utenteLabel = new Label();
			utenteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			utenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			utenteLabel.Location = new System.Drawing.Point(0, 0);
			utenteLabel.Name = "_utenteLabel";
			utenteLabel.TabIndex = 0;
			utenteLabel.Text = Spesa.SpeseGruppo.Gruppo.MembriGruppo[index].Nome + " " + Spesa.SpeseGruppo.Gruppo.MembriGruppo[index].Cognome;
			utenteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			SplitContainer splitContainer = new SplitContainer();
			splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			splitContainer.Location = new System.Drawing.Point(3, 3);
			splitContainer.Name = "_splitContainer";
			splitContainer.IsSplitterFixed = true;
			splitContainer.Panel1.Controls.Add(utenteLabel);
			splitContainer.Panel2.Controls.Add(numericUpDown);
			splitContainer.SplitterDistance = 75;
			splitContainer.TabIndex = 0;

			panel.Height = 40 + 40*index;
			panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
			panel.Controls.Add(splitContainer, 0, index);

			Dictionary.Add(Spesa.SpeseGruppo.Gruppo.MembriGruppo[index], numericUpDown);
		}

		void ConfermaButton_Click(object sender, EventArgs e)
		{
			PartiForm.ErrorProvider.Clear();
			Spesa.Parti = new Parti(Spesa.SpeseGruppo.Gruppo);
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
				PartiForm.ErrorProvider.SetIconAlignment(PartiForm.ConfermaButton, ErrorIconAlignment.MiddleLeft);
				PartiForm.ErrorProvider.SetError(PartiForm.ConfermaButton, ae.Message);
			}
		}
	}
}