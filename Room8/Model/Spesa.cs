using System;

namespace Room8
{
	public class Spesa
	{
		private readonly string _id;
		private readonly Gruppo _gruppo;
		private readonly string _descrizione;
		private readonly decimal _importo;
		private readonly Utente _pagante;
		private readonly IMetodoDiDivisione _metodoDivisione;
		private readonly Parti _parti;
		private readonly DateTime _data;
		private readonly string _note;

		private string GenerateId ()
		{
			return Guid.NewGuid ().ToString ();
		}

		public Spesa (Gruppo gruppo, string descrizione, decimal importo, Utente pagante, string nomeMetodo, DateTime data)
		{
			this._id = GenerateId ();
			this._gruppo = gruppo;
			this._descrizione = descrizione;
			this._importo = importo;
			this._pagante = pagante;
			this._metodoDivisione = MetodoDiDivisioneFactory.getMetodoDiDivisione (nomeMetodo);
			this._parti = new Parti (gruppo);
			this._data = data;

			if (!gruppo.MembriGruppo.Contains (pagante)) {
				throw new ArgumentException("Il pagante non fa parte del gruppo");
			}
		}

		public Spesa (Gruppo gruppo, string descrizione, decimal importo, Utente pagante, string nomeMetodo, DateTime data, string note)
			: this (gruppo, descrizione, importo, pagante, nomeMetodo, data)
		{
			if (!String.IsNullOrEmpty (note))
				this._note = note;		
		}

		public string Id {
			get { return _id; }
		}

		public Gruppo Gruppo {
			get { return _gruppo; }
		}

		public string Descrizione {
			get { return _descrizione; }
		}

		public decimal Importo {
			get { return _importo; }
		}

		public Utente Pagante {
			get { return _pagante; }
		}

		public IMetodoDiDivisione MetodoDivisione {
			get { return _metodoDivisione; }
		}

		public Parti Parti {
			get { return _parti; }
		}

		public DateTime Data {
			get { return _data; }
		}

		public string Note {
			get { return _note; }
		}

		public void generaMovimenti ()
		{
			foreach (var item in MetodoDivisione.DividiSpesa(Importo, Parti)) {
				if (item.Key.Equals (Pagante))
					continue;
				else {
					Movimento movimento = new Movimento (Pagante, item.Key, item.Value, this);
					movimento.Sorgente.AggiungiMovimentoDiDenaro (movimento);
					movimento.Destinazione.AggiungiMovimentoDiDenaro (movimento);
				}
			}

		}
	}
}
