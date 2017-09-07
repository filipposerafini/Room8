using System;
using System.Collections.Generic;

namespace Room8
{
	public class Parti
	{
		private readonly Dictionary<Utente, int> _divisione;

		public Parti(Gruppo gruppo)
		{
			if (gruppo == null)
				throw new ArgumentNullException("gruppo");

			_divisione = new Dictionary<Utente, int>();
			foreach (var utente in gruppo.MembriGruppo)
			{
				_divisione.Add(utente, 0);
			}
		}

		public Dictionary<Utente, int> Divisione
		{
			get { return _divisione; }
		}

		public void ImpostaParte(Utente utente, int parte)
		{
			if (utente == null)
				throw new ArgumentException("utente null");

			if (Divisione.ContainsKey(utente))
				Divisione[utente] = parte;
			else
				throw new ArgumentException("utente non presente");
		}

		public void ControllaParti(string nomeMetodo, decimal totale)
		{
			switch (nomeMetodo)
			{
				case "percentuale" :
					ControllaPercentuale();
					break;
				case "per quote" :
					ContollaQuote();
					break;
				case "per importi precisi" :
					ControllaImportiPrecisi(totale);
					break;
				default:
					return;
			}
		}

		private void ControllaPercentuale()
		{
			int tot = 0;
			foreach (int perc in Divisione.Values)
				tot += perc;

			if (tot != 100)
				throw new ArgumentException("La somma delle percentuali deve essere 100");
		}

		private void ContollaQuote()
		{
			foreach (var quota in Divisione.Values)
				if (quota > 0)
					return;
			throw new ArgumentException("Almeno una quota deve essere diversa da 0");
		}

		private void ControllaImportiPrecisi(decimal totale)
		{
			decimal tot = 0;
			foreach (var importo in Divisione.Values)
				tot += importo;
			if (tot != totale)
				throw new ArgumentException("La somma degli importi deve essere uguale al totale speso");
		}
	}
}
