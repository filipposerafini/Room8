using System;
using System.Collections.Generic;

namespace Room8
{
	public class Parti
	{
		// Parti verrà generato tramire la view
		// Per ogni utente che sta insereno la spesa
		// prendo l'utente e la sua parte
		// genero quest'oggetto

		private Dictionary<Utente, int> _divisione;

		public Parti(Dictionary<Utente, int> divisione)
		{
			if (divisione == null)
				throw new ArgumentException("parti null");
			
			_divisione = divisione;
		}

		public Dictionary<Utente, int> Divisione
		{
			get { return _divisione; }

			set { _divisione = value; }
		}

	}
}
