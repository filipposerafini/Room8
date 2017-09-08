using System;
using System.Collections.Generic;

namespace Room8
{
	public class Spesa
	{
		private readonly string _id;
		private SpeseGruppo _speseGruppo;
		private string _descrizione;
		private decimal _importo;
        private Utente _pagante;
		private IMetodoDiDivisione _metodoDivisione;
		private Parti _parti;
		private DateTime _data;
        private readonly List<Movimento> _movimenti;
        private readonly List<Commento> _commenti;

		public Spesa()
		{
			this._id = Guid.NewGuid().ToString();
			this._movimenti = new List<Movimento>();
			this._commenti = new List<Commento>();
		}

		public string Id
		{
			get { return _id; }
		}

		public SpeseGruppo SpeseGruppo
		{
			get { return _speseGruppo; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("gruppo");
				_speseGruppo = value;
			}
		}

		public string Descrizione
		{
			get { return _descrizione; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("La descrizione non può essere vuota", "descrizione");
				_descrizione = value;
			}
		}

		public decimal Importo
		{
			get { return _importo; }
			set
			{
				if (value <= 0)
					throw new ArgumentException("L'importo deve essere maggiore di 0", "importo");
				_importo = value;
			}
		}

		public Utente Pagante
		{
			get { return _pagante; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("pagante");
                if (!SpeseGruppo.Gruppo.MembriGruppo.Contains(value as Utente))
					throw new ArgumentException("Il pagante deve essere un membro del gruppo", "pagante");
				
				_pagante = value;
			}
		}

		public IMetodoDiDivisione MetodoDivisione
		{
			get { return _metodoDivisione; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("metodo di divisione");
				_metodoDivisione = value;
			}
		}

		public Parti Parti
		{
			get { return _parti; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("parti");
				_parti = value;
			}
		}

		public DateTime Data
		{
			get { return _data; }
			set
			{
                if (value.Equals(DateTime.MinValue))
					throw new ArgumentNullException("data");
				if (value.CompareTo(DateTime.Now) > 0)
					throw new ArgumentException("La data non può essere successiva a quella di oggi", "data");
				_data = value;
			}
		}

        public IList<Movimento> Movimenti
        {
            get { return _movimenti.AsReadOnly(); }
        }

        public IList<Commento> Commenti
        {
            get { return _commenti.AsReadOnly(); }
        }

        public void AggiungiCommento(Commento commento)
        {
            _commenti.Add(commento);
        }

		public void GeneraMovimenti()
		{
			foreach (var item in _metodoDivisione.DividiSpesa(Importo, Parti))
				if (item.Key.Equals(Pagante))
					continue;
				else
                    _movimenti.Add(new Movimento((Pagante as Utente), item.Key, item.Value, this));
		}
	}
}
