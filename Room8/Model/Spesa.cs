using System;
namespace Room8
{
	public class Spesa
	{
		private readonly string _id;
		private readonly SpeseGruppo _speseGruppo;
		private string _descrizione;
		private decimal _importo;
		private DateTime _data;
		private string _note;

		private string GenerateId()
		{
			return Guid.NewGuid().ToString();
		}

		public Spesa(SpeseGruppo speseGruppo, string descrizione, decimal importo, DateTime data)
		{
			this._id = GenerateId();
			this._descrizione = descrizione;
			this._importo = importo;
			this._data = data;
		}

		public Spesa(SpeseGruppo speseGruppo, string descrizione, decimal importo, DateTime data, string note)
			: this(speseGruppo, descrizione, importo, data)
		{
			if (!String.IsNullOrEmpty(note))
				this._note = note;		
		}

		public string Id
		{
			get { return _id; }
		}

		public SpeseGruppo SpeseGruppo
		{
			get { return _speseGruppo; }
		}

		public string Descrizione
		{
			get { return _descrizione; }
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentException("descrizione null or empty");

				_descrizione = value;
			}
		}

		public decimal Importo
		{
			get { return _importo; }
			set
			{
				if (value <= 0)
					throw new ArgumentException("importo minore di zero");

				_importo = value;
			}
		}

		public DateTime Data
		{
			get { return _data; }
			set
			{
				if (value == null)
					throw new ArgumentException("data null");

				_data = value;
			}
		}

		public string Note
		{
			get { return _note; }
			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentException("note null or empty");

				_note = value;
			}
		}
	}
}
