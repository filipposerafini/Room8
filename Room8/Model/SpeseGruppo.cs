using System;
using System.Collections.Generic;
using System.Linq;

namespace Room8
{
	public class SpeseGruppo
	{
		private Gruppo _gruppo;
		private List<Spesa> _spese;

		public SpeseGruppo(Gruppo gruppo)
		{
			this._gruppo = gruppo;
			this._spese = new List<Spesa>();
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }
            set
            { 
                if (value == null)
                    throw new ArgumentException("gruppo");
                _gruppo = value;
            }    
		}

		public IList<Spesa> Spese
		{
			get { return _spese; }
		}

		public void AggiungiSpesa(Spesa spesa)
		{
			if (spesa == null)
				throw new ArgumentException("Spesa null");

			try
			{
				spesa.GeneraMovimenti();
				_spese.Add(spesa);
			}
			catch (ArgumentException)
			{
                throw new ArgumentException("Spesa non è stata inserita");
			}
		}

		public void ModificaSpesa(Spesa daModificare, Spesa nuova)
		{
			if (daModificare == null)
				throw new ArgumentException("daModificare null");
			if (nuova == null)
				throw new ArgumentException("nuova null");

			RimuoviSpesa(daModificare);
			AggiungiSpesa(nuova);
		}

		public void RimuoviSpesa(Spesa spesa)
		{
			if (spesa == null)
				throw new ArgumentException("Spesa null");

			if (_spese.Remove(spesa))
			{
                foreach (var movimento in spesa.Movimenti)
					movimento.RimuoviMovimentoDiDenaro();
			}
			else
				throw new ArgumentException("Spesa non trovata");
		}
	}
}
