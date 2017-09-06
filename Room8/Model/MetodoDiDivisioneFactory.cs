using System;
using System.Collections.Generic;
using System.Linq;

namespace Room8
{
	public static class MetodoDiDivisioneFactory
	{
		private static readonly Dictionary<string, IMetodoDiDivisione> _dictionary;

		static MetodoDiDivisioneFactory()
		{
			_dictionary = new Dictionary<string, IMetodoDiDivisione>();
			_dictionary.Add("equa", new DivisioneEqua());
			_dictionary.Add("percentuale", new DivisionePercentuale());
			_dictionary.Add("per quote", new DivisionePerQuote());
		}

		public static IMetodoDiDivisione getMetodoDiDivisione(string nome)
		{
			if (!_dictionary.ContainsKey(nome))
				throw new ArgumentException("Metodo di divisione inesistente: " + nome);
			return _dictionary[nome];
		}

		public static string getNomeMetodo(IMetodoDiDivisione metodo)
		{
			return _dictionary.FirstOrDefault(x => x.Value == metodo).Key;
		}

		private abstract class MetodoDiDivisione : IMetodoDiDivisione
		{
			public Dictionary<Utente, decimal> DividiSpesa(decimal totale, Parti parti)
			{
				Dictionary<Utente, decimal> divisione = new Dictionary<Utente, decimal>();
				decimal tot = 0;
				foreach (Utente utente in parti.Divisione.Keys)
				{
					divisione[utente] = Dividi(totale, utente, parti.Divisione);
					tot += divisione[utente];
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
				return totale * ((decimal)parti[utente] / 100);
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
