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
			_dictionary.Add("per importi precisi", new DivisionePerImportiPrecisi());
		}

		public static IMetodoDiDivisione GetMetodoDiDivisione(string nome)
		{
			if (!_dictionary.ContainsKey(nome))
				throw new ArgumentException("Metodo di divisione inesistente: " + nome);
			return _dictionary[nome];
		}

		private abstract class MetodoDiDivisione : IMetodoDiDivisione
		{
			public Dictionary<Utente, decimal> DividiSpesa(decimal totale, Parti parti)
			{
				Dictionary<Utente, decimal> divisione = new Dictionary<Utente, decimal>();
				foreach (Utente utente in parti.Divisione.Keys)
					divisione[utente] = Dividi(totale, utente, parti);

				return divisione;
			}

			protected abstract decimal Dividi(decimal totale, Utente utente, Parti parti);

			public abstract void ControllaParti(Parti parti, decimal totale);
		}

		private class DivisioneEqua : MetodoDiDivisione
		{
			protected override decimal Dividi(decimal totale, Utente utente, Parti parti)
			{
				return totale / parti.Divisione.Keys.Count;
			}

			public override void ControllaParti(Parti parti, decimal totale)
			{
				return;
			}
		}

		private class DivisionePercentuale : MetodoDiDivisione
		{
			protected override decimal Dividi(decimal totale, Utente utente, Parti parti)
			{
				return totale * ((decimal)parti.Divisione[utente] / 100);
			}

			public override void ControllaParti(Parti parti, decimal totale)
			{
				if (parti.Divisione.Values.Sum() != 100)
					throw new ArgumentException("La somma delle percentuali deve essere 100");
			}
		}

		private class DivisionePerQuote : MetodoDiDivisione
		{
			protected override decimal Dividi(decimal totale, Utente utente, Parti parti)
			{
				return (totale / parti.Divisione.Values.Sum()) * parti.Divisione[utente];
			}

			public override void ControllaParti(Parti parti, decimal totale)
			{
				// TODO
				foreach (var parte in parti.Divisione.Values)
					if (parte % 1 != 0)
						throw new ArgumentException("Le quote devono essere degli interi");
				if (parti.Divisione.Values.Sum() == 0)
					throw new ArgumentException("Almeno una quota deve essere diversa da 0");
			}
		}

		private class DivisionePerImportiPrecisi : MetodoDiDivisione
		{
			protected override decimal Dividi(decimal totale, Utente utente, Parti parti)
			{
				return parti.Divisione[utente];
			}

			public override void ControllaParti(Parti parti, decimal totale)
			{
				if (parti.Divisione.Values.Sum() != totale)
					throw new ArgumentException("La somma degli importi deve essere uguale totale speso");
			}
		}
	}
}
