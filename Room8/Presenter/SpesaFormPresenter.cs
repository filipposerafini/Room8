using System;
using System.Linq;
using System.Windows.Forms;
using Room8.View;

namespace Room8
{
	public class SpesaFormPresenter
	{
		private readonly SpesaForm _spesaForm;
		private readonly Utente _utente;
		private Spesa _spesa;
		private readonly IPresenterEvent _observer;

		public SpesaFormPresenter(SpesaForm spesaForm, Utente utente, IPresenterEvent observer, Spesa spesa)
		{
			_spesaForm = spesaForm;
			_utente = utente;
			_observer = observer;
			Spesa = spesa;
			InitializeEvents();
			InitializeUI();
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
			set { _spesa = value; }
		}

		public IPresenterEvent Observer
		{
			get { return _observer; }
		}

		private void InitializeEvents()
		{
			SpesaForm.GruppoComboBox.SelectedIndexChanged += GruppoComboBox_SelectIndexChanged;
			SpesaForm.PercentualeRadioButton.Click += RadioButton_Click;
			SpesaForm.QuoteRadioButton.Click += RadioButton_Click;
			SpesaForm.ImportiPrecisiRadioButton.Click += RadioButton_Click;
			SpesaForm.CommentoButton.Click += CommentoButton_Click;
			SpesaForm.ConfermaButton.Click += ConfermaButton_Click;
		}

		private void InitializeUI()
		{
			SpesaForm.GruppoComboBox.DataSource = Utente.Gruppi;
			SpesaForm.GruppoComboBox.DisplayMember = "Nome";
			if (Spesa != null)
			{
				SpesaForm.GruppoComboBox.SelectedItem = Spesa.SpeseGruppo.Gruppo;
				SpesaForm.DescrizioneTextBox.Text = Spesa.Descrizione;
				SpesaForm.NumericUpDown.Value = Spesa.Importo;
				SpesaForm.PaganteComboBox.SelectedItem = Spesa.Pagante;
				SpesaForm.DateTimePicker.Value = Spesa.Data;
			}
			else
				Spesa = new Spesa(SpesaForm.GruppoComboBox.SelectedItem as Gruppo);
		}

		private void GruppoComboBox_SelectIndexChanged(object sender, EventArgs e)
		{
			SpesaForm.PaganteComboBox.DataSource = (SpesaForm.GruppoComboBox.SelectedItem as Gruppo).MembriGruppo;
			SpesaForm.PaganteComboBox.DisplayMember = "Nome";
		}

		private void RadioButton_Click(object sender, EventArgs e)
		{
			SpesaForm.ErrorProvider.Clear();
			try
			{
				Spesa.SpeseGruppo = (SpesaForm.GruppoComboBox.SelectedItem as Gruppo).SpeseGruppo;
				string nomeMetodo = SpesaForm.RadioPanel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString();
				Spesa.MetodoDivisione = MetodoDiDivisioneFactory.GetMetodoDiDivisione(nomeMetodo);
				Spesa.Importo = SpesaForm.NumericUpDown.Value;
				PartiForm partiForm = new PartiForm();
				new PartiFormPresenter(partiForm, Spesa, nomeMetodo);
				if (partiForm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
				{
					SpesaForm.EquoRadioButton.Checked = true;
					nomeMetodo = SpesaForm.RadioPanel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString();
					Spesa.MetodoDivisione = MetodoDiDivisioneFactory.GetMetodoDiDivisione(nomeMetodo);
				}
			}
			catch (ArgumentException ae)
			{
				SpesaForm.ErrorProvider.SetError(SpesaForm.NumericUpDown, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
				SpesaForm.EquoRadioButton.Checked = true;
				string nomeMetodo = SpesaForm.RadioPanel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString();
				Spesa.MetodoDivisione = MetodoDiDivisioneFactory.GetMetodoDiDivisione(nomeMetodo);
			}
		}

		private void CommentoButton_Click(object sender, EventArgs e)
		{
			CommentoForm commentoForm = new CommentoForm();
			new CommentoFormPresenter(commentoForm, Spesa, Utente);
			commentoForm.ShowDialog();
		}

		private void ConfermaButton_Click(object sender, EventArgs e)
		{
			SpesaForm.ErrorProvider.Clear();
			try
			{
				Spesa.SpeseGruppo = (SpesaForm.GruppoComboBox.SelectedItem as Gruppo).SpeseGruppo;
				Spesa.Descrizione = SpesaForm.DescrizioneTextBox.Text;
				Spesa.Importo = SpesaForm.NumericUpDown.Value;
				Spesa.Pagante = (Utente)SpesaForm.PaganteComboBox.SelectedItem;
				string nomeMetodo = SpesaForm.RadioPanel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Tag.ToString();
				Spesa.MetodoDivisione = MetodoDiDivisioneFactory.GetMetodoDiDivisione(nomeMetodo);
				Spesa.Data = SpesaForm.DateTimePicker.Value;
				Spesa.SpeseGruppo.Gruppo.SpeseGruppo.AggiungiSpesa(Spesa);
				Observer.AggiornaUI();
				SpesaForm.Close();
			}
			catch (ArgumentException ae)
			{
				Control control;
				switch (ae.ParamName)
				{
					case "descrizione":
						control = SpesaForm.DescrizioneTextBox;
						break;
					case "importo":
						control = SpesaForm.NumericUpDown;
						break;
					case "pagante":
						control = SpesaForm.PaganteComboBox;
						break;
					case "data":
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
