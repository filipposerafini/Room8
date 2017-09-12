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
			foreach (var utente in gruppo.MembriGruppo)
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
				throw new ArgumentNullException("utente");
			if (parte < 0)
				throw new ArgumentException("La parte non può essere negativa");

			if (Divisione.ContainsKey(utente))
				Divisione[utente] = parte;
			else
				throw new ArgumentException("Utente non presente");
		}
	}
}
