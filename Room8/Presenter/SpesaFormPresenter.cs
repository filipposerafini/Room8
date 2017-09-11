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
		private readonly Spesa _spesa;
		private readonly Spesa _daModificare;
		private readonly IPresenterEvent _observer;

		public SpesaFormPresenter(SpesaForm spesaForm, Utente utente, IPresenterEvent observer, Spesa spesa)
		{
			_spesaForm = spesaForm;
			_utente = utente;
			_observer = observer;
			_spesa = new Spesa();
			_daModificare = spesa;
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
		}

		public Spesa DaModificare
		{
			get { return _daModificare; }
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
			SpesaForm.EliminaButton.Click += EliminaButton_Click;
		}

		private void InitializeUI()
		{
			SpesaForm.EliminaButton.Hide();
			SpesaForm.GruppoComboBox.DataSource = Utente.Gruppi;
			SpesaForm.GruppoComboBox.DisplayMember = "Nome";
			if (DaModificare != null)
			{
				SpesaForm.EliminaButton.Show();
				SpesaForm.GruppoComboBox.SelectedItem = DaModificare.SpeseGruppo.Gruppo;
				SpesaForm.DescrizioneTextBox.Text = DaModificare.Descrizione;
				SpesaForm.NumericUpDown.Value = DaModificare.Importo;
				SpesaForm.PaganteComboBox.SelectedItem = DaModificare.Pagante;
				SpesaForm.DateTimePicker.Value = DaModificare.Data;
				SpesaForm.RadioPanel.Controls.OfType<RadioButton>().FirstOrDefault
				         (n => n.Tag.Equals(MetodoDiDivisioneFactory.GetNomeMetodo
				                            (DaModificare.MetodoDivisione))).Checked = true;
			}
		}

		private void GruppoComboBox_SelectIndexChanged(object sender, EventArgs e)
		{
			SpesaForm.PaganteComboBox.DataSource = (SpesaForm.GruppoComboBox.SelectedItem as Gruppo).MembriGruppo;
			SpesaForm.PaganteComboBox.DisplayMember = "Nome";
			Spesa.SpeseGruppo = (SpesaForm.GruppoComboBox.SelectedItem as Gruppo).SpeseGruppo;
			Spesa.Parti = new Parti(Spesa.SpeseGruppo.Gruppo);
		}

		private void RadioButton_Click(object sender, EventArgs e)
		{
			SpesaForm.ErrorProvider.Clear();
			try
			{
				Spesa.Pagante = (SpesaForm.PaganteComboBox.SelectedItem as Utente);
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

		void EliminaButton_Click(object sender, EventArgs e)
		{
			Spesa.SpeseGruppo.RimuoviSpesa(Spesa);
			Observer.AggiornaUI();
			SpesaForm.DialogResult = DialogResult.OK;
		}

		private void ConfermaButton_Click(object sender, EventArgs e)
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
				if (DaModificare != null)
					Spesa.SpeseGruppo.RimuoviSpesa(DaModificare);
				Spesa.SpeseGruppo.AggiungiSpesa(Spesa);
				Observer.AggiornaUI();
				SpesaForm.DialogResult = DialogResult.OK;
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
						SpesaForm.ErrorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleLeft);
						break;
				}
				SpesaForm.ErrorProvider.SetError(control, ae.Message.Substring(0, ae.Message.IndexOf('\n')));
			}
		}
	}
}
