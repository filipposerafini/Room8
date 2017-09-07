﻿using System;
using System.Linq;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	public class SpesaFormPresenter
	{
		private readonly SpesaForm _spesaForm;
		private readonly Utente _utente;
		private readonly Spesa _spesa;

		public SpesaFormPresenter(SpesaForm spesaForm, Utente utente)
		{
			this._spesaForm = spesaForm;
			this._utente = utente;
			this._spesa = new Spesa();
			InitializeEvents();

			SpesaForm.GruppoComboBox.DataSource = utente.Gruppi;
			SpesaForm.GruppoComboBox.DisplayMember = "Nome";
		}

		public SpesaFormPresenter(SpesaForm spesaForm, Utente utente, Spesa daModificare)
		{
			this._spesaForm = spesaForm;
			this._utente = utente;
			this._spesa = daModificare;
			InitializeEvents();

			SpesaForm.GruppoComboBox.DataSource = utente.Gruppi;
			SpesaForm.GruppoComboBox.DisplayMember = "Nome";

			SpesaForm.GruppoComboBox.SelectedItem = daModificare.SpeseGruppo.Gruppo;
			SpesaForm.DescrizioneTextBox.Text = daModificare.Descrizione;
			SpesaForm.NumericUpDown.Value = daModificare.Importo;
			SpesaForm.PaganteComboBox.SelectedItem = daModificare.Pagante;
			SpesaForm.DateTimePicker.Value = daModificare.Data;
		}

		public SpesaForm SpesaForm
		{
			get { return _spesaForm; }
		}

		public Utente Utente
		{
			get { return _utente; }
		}

		public Spesa Spesa
		{
			get { return _spesa; }
		}

		private void InitializeEvents()
		{
			SpesaForm.GruppoComboBox.SelectedIndexChanged += GruppoComboBox_SelectIndexChanged;
			SpesaForm.PercentualeRadioButton.Click += RadioButton_Click;
			SpesaForm.QuoteRadioButton.Click += RadioButton_Click;
			SpesaForm.ConfermaButton.Click += ConfermaButton_Click;
		}

		void GruppoComboBox_SelectIndexChanged(object sender, EventArgs e)
		{
			SpesaForm.PaganteComboBox.DataSource = (SpesaForm.GruppoComboBox.SelectedItem as Gruppo).MembriGruppo;
			SpesaForm.PaganteComboBox.DisplayMember = "Nome";
            Spesa.SpeseGruppo = (SpesaForm.GruppoComboBox.SelectedItem as Gruppo).SpeseGruppo;
			Spesa.Parti = new Parti(Spesa.SpeseGruppo.Gruppo);
		}

		void RadioButton_Click(object sender, EventArgs e)
		{
			Spesa.Parti = new Parti(Spesa.SpeseGruppo.Gruppo);
			string nomeMetodo = SpesaForm.RadioPanel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString();
			PartiForm partiForm = new PartiForm();
			new PartiFormPresenter(partiForm, Spesa, nomeMetodo);
			if (partiForm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				SpesaForm.EquoRadioButton.Checked = true;
		}

		void ConfermaButton_Click(object sender, EventArgs e)
		{
			SpesaForm.ErrorProvider.Clear();
			try
			{
				Spesa.Descrizione = SpesaForm.DescrizioneTextBox.Text;
				Spesa.Importo = SpesaForm.NumericUpDown.Value;
				Spesa.Pagante = (Utente)SpesaForm.PaganteComboBox.SelectedItem;
				string nomeMetodo = SpesaForm.RadioPanel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString();
				Spesa.MetodoDivisione = MetodoDiDivisioneFactory.GetMetodoDiDivisione(nomeMetodo);
				Spesa.Data = SpesaForm.DateTimePicker.Value;

                Spesa.SpeseGruppo.Gruppo.SpeseGruppo.AggiungiSpesa(Spesa);
				SpesaForm.Close();
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "descrizione" : 
						control = SpesaForm.DescrizioneTextBox;
						break;
					case "importo" :
						control = SpesaForm.NumericUpDown;
						break;
					case "pagante" :
						control = SpesaForm.PaganteComboBox;
						break;
					case "data" :
						control = SpesaForm.DateTimePicker;
						break;
					default:
						control = SpesaForm.ConfermaButton;
						break;
				}
				SpesaForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}
	}
}
