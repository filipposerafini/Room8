﻿using System;
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
			_gruppo = gruppo;
			_spese = new List<Spesa>();
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }  
		}

		public IList<Spesa> Spese
		{
			get { return _spese; }
		}

		public void AggiungiSpesa(Spesa spesa)
		{
			if (spesa == null)
				throw new ArgumentNullException("spesa");

			spesa.GeneraMovimenti();
			_spese.Add(spesa);
		}

		public void ModificaSpesa(Spesa daModificare, Spesa nuova)
		{
			if (daModificare == null)
				throw new ArgumentNullException("daModificare");
			if (nuova == null)
				throw new ArgumentNullException("nuova");

			RimuoviSpesa(daModificare);
			AggiungiSpesa(nuova);
		}

		public void RimuoviSpesa(Spesa spesa)
		{
			if (spesa == null)
				throw new ArgumentNullException("spesa");

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
