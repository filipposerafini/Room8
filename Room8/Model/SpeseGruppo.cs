using System;
using System.Collections.Generic;
using System.Linq;

namespace Room8
{
	public class SpeseGruppo
	{
		private readonly Gruppo _gruppo;
		private readonly List<Spesa> _spese;

		public SpeseGruppo(Gruppo gruppo)
		{
			this._gruppo = gruppo;
			this._spese = new List<Spesa>();
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }
		}

		public IList<Spesa> Spese
		{
			get { return _spese.AsReadOnly(); }
		}

		public void AggiungiSpesa(Spesa spesa)
		{
			if (spesa == null)
				throw new ArgumentException("Spesa null");

			_spese.Add(spesa);
			spesa.generaMovimenti();
		}

		public void RimuoviSpesa(Spesa spesa)
		{
			if (spesa == null)
				throw new ArgumentException("Spesa null");

			if (_spese.Remove(spesa))
			{
				List<MovimentoDiDenaro> daEliminare;
				foreach (var utente in Gruppo.MembriGruppo.Utenti)
				{
					daEliminare = new List<MovimentoDiDenaro>();
					foreach (var movimento in utente.MovimentiDiDenaro)
						if (movimento is Movimento && (movimento as Movimento).Spesa.Equals(spesa))
							daEliminare.Add(movimento);

					foreach (var movimento in daEliminare)
						utente.RimuoviMovimentoDiDenaro(movimento);
				}
			}
			else
				throw new ArgumentException("Spesa non trovata");
		}
	}
}
