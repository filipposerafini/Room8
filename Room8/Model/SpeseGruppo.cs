using System;
using System.Collections.Generic;

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
				// TODO Forse qui rimuoverei anche tutti i movimenti generati dalla spesa stessa
			}
			else
				throw new ArgumentException("Spesa non trovata");
		}
	}
}
