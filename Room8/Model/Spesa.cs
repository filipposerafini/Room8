using System;

namespace Room8
{
	public class Spesa
	{
		private readonly string _id;
		private Gruppo _gruppo;
		private string _descrizione;
		private decimal _importo;
		private Utente _pagante;
		private IMetodoDiDivisione _metodoDivisione;
		private Parti _parti;
		private DateTime _data;
		private string _note;

		public Spesa()
		{
			this._id = Guid.NewGuid().ToString();
		}

		public string Id
		{
			get { return _id; }
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("gruppo");
				_gruppo = value;
				Parti = new Parti(value);
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
				if (!Gruppo.MembriGruppo.Contains(value))
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
				if (value == null)
					throw new ArgumentNullException("data");
				_data = value;
			}
		}

		public string Note
		{
			get { return _note; }
			set
			{
				_note = value;
			}
		}

		public void generaMovimenti()
		{
			foreach (var item in _metodoDivisione.DividiSpesa(Importo, Parti))
			{
				if (item.Key.Equals(Pagante))
					continue;
				else
				{
					Movimento movimento = new Movimento(Pagante, item.Key, item.Value, this);
					movimento.AggiungiMovimentoDiDenaro();
				}
			}

		}
	}
}
