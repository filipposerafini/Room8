using System;
using System.Collections.Generic;

namespace Room8
{
	public static class MetodoDiDivisioneFactory
	{
		private static readonly Dictionary<string, IMetodoDiDivisione> _dictionary;

		static MetodoDiDivisioneFactory()
		{
			_dictionary = new Dictionary<string, IMetodoDiDivisione>();
			_dictionary.Add("Equa", new DivisioneEqua());
			_dictionary.Add("Percentuale", new DivisionePercentuale());
			_dictionary.Add("Per quote", new DivisionePerQuote());
		}

		public static IMetodoDiDivisione getMetodoDiDivisione(string nome)
		{
			if (!_dictionary.ContainsKey(nome))
				throw new ArgumentException(nome);
			return _dictionary[nome];
		}

		private abstract class MetodoDiDivisione : IMetodoDiDivisione
		{
			public Dictionary<Utente, decimal> DividiSpesa(decimal totale, Dictionary<Utente, int> parti)
			{
				Dictionary<Utente, decimal> divisione = new Dictionary<Utente, decimal>();
				decimal tot = 0;
				foreach (Utente utente in parti.Keys)
				{
					divisione[utente] = Dividi(totale, utente, parti);
					tot += divisione[utente];
				}

				if (totale != tot) {
					throw new ApplicationException();
				}

				return divisione;
			}

			protected abstract decimal Dividi(decimal totale, Utente utente, Dictionary<Utente, int> parti);
		}

		private class DivisioneEqua : MetodoDiDivisione
		{
			protected override decimal Dividi(decimal totale, Utente utente, Dictionary<Utente, int> parti)
			{
				return totale / parti.Keys.Count;
			}
		}

		private class DivisionePercentuale : MetodoDiDivisione
		{
			protected override decimal Dividi(decimal totale, Utente utente, Dictionary<Utente, int> parti)
			{
				return totale * (parti[utente] / 100);
			}
		}

		private class DivisionePerQuote : MetodoDiDivisione
		{
			protected override decimal Dividi(decimal totale, Utente utente, Dictionary<Utente, int> parti)
			{
				int quote = 0;
				foreach (int quota in parti.Values)
					quote += quota;

				return (totale / quote) * parti[utente];
			}
		}
	}
}
