using System;
namespace Room8
{
	public class Spesa
	{
		private readonly string _id;
		private readonly Gruppo _gruppo;
		private string _descrizione;
		private decimal _importo;
		private Utente _pagante;
		private IMetodoDiDivisione _metodoDivisione;
		private Parti _parti;
		private DateTime _data;
		private string _note;

		private string GenerateId()
		{
			return Guid.NewGuid().ToString();
		}

		public Spesa(Gruppo gruppo, string descrizione, decimal importo, Utente pagante, string nomeMetodo, DateTime data)
		{
			this._id = GenerateId();
			this._gruppo = gruppo;
			this._descrizione = descrizione;
			this._importo = importo;
			this._pagante = pagante;
			this._metodoDivisione = MetodoDiDivisioneFactory.getMetodoDiDivisione(nomeMetodo);
			this._parti = new Parti(gruppo.MembriGruppo);
			this._data = data;

			if (!gruppo.MembriGruppo.Utenti.Contains(pagante)) 
			{
				throw new Exception ("Il pagante non fa parte del gruppo");
			}
		}

		public Spesa(Gruppo gruppo, string descrizione, decimal importo, Utente pagante, string nomeMetodo, DateTime data, string note)
			: this(gruppo, descrizione, importo, pagante, nomeMetodo, data)
		{
			if (!String.IsNullOrEmpty(note))
				this._note = note;		
		}

		public string Id
		{
			get { return _id; }
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }
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

		public Utente Pagante
		{
			get { return _pagante; }

			set
			{
				if (value == null)
					throw new ArgumentException("Pagante null");
				_pagante = value;
			}
		}

		public IMetodoDiDivisione MetodoDivisione
		{
			get { return _metodoDivisione; }

			set
			{
				if (value == null)
					throw new ArgumentException("MetodoDivisione null");
				_metodoDivisione = value;
			}
		}

		public Parti Parti
		{
			get { return _parti; }

			set
			{
				if (value == null)
					throw new ArgumentException("Parti null");
				_parti = value;
			}
		}

		public DateTime Data
		{
			get { return _data; }
			set
			{
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

		public void generaMovimenti()
		{
			try
			{
				foreach (var item in MetodoDivisione.DividiSpesa(Importo, Parti))
				{
					if (item.Key.Equals(Pagante))
						continue;
					else
					{
						Movimento movimento = new Movimento(Pagante, item.Key, item.Value, this);
						movimento.Sorgente.AggiungiMovimentoDiDenaro(movimento);
						movimento.Destinazione.AggiungiMovimentoDiDenaro(movimento);
					}
				}
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Errore");
			}
		}
	}
}
