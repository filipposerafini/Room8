using System;
using System.Collections.Generic;

namespace Room8
{
	public class Parti
	{
		private readonly Dictionary<Utente, decimal> _divisione;

		public Parti(Gruppo gruppo)
		{
			if (gruppo == null)
				throw new ArgumentNullException("gruppo");

			_divisione = new Dictionary<Utente, decimal>();
			foreach (var utente in gruppo.MembriGruppo.Utenti)
			{
				_divisione.Add(utente, 0);
			}
		}

		public Dictionary<Utente, decimal> Divisione
		{
			get { return _divisione; }
		}

		public void ImpostaParte(Utente utente, decimal parte)
		{
			if (utente == null)
				throw new ArgumentException("utente null");

			if (Divisione.ContainsKey(utente))
				Divisione[utente] = parte;
			else
				throw new ArgumentException("utente non presente");
		}
	}
}
