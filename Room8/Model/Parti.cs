using System;
using System.Collections.Generic;

namespace Room8
{
	public class Parti
	{
		private readonly Dictionary<Utente, int> _divisione;

		public Parti(MembriGruppo membriGruppo)
		{
			if (membriGruppo == null)
				throw new ArgumentException("membriGruppo null");
			
			_divisione = new Dictionary<Utente, int>();
			foreach (var utente in membriGruppo.Utenti)
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
	}
}
