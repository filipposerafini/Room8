using System;
using System.Collections.Generic;

namespace Room8
{
	public class GestorePagamento
	{
		private Spesa _spesa;
		private Utente _pagante;
		private IMetodoDiDivisione _metodoDivisione;

		public GestorePagamento(Spesa spesa, Utente pagante, string nomeMetodo)
		{
			if (spesa == null)
				throw new ArgumentException("spesa null");
			if (pagante == null)
				throw new ArgumentException("pagante null");
			if (String.IsNullOrEmpty(nomeMetodo))
				throw new ArgumentException("metodoDivisione null");
			
			this._pagante = pagante;
			this._spesa = spesa;
			this._metodoDivisione = MetodoDiDivisioneFactory.getMetodoDiDivisione(nomeMetodo);
		}

		Utente Pagante
		{
			get { return _pagante; }

			set
			{
				if (value == null)
					throw new ArgumentException("Pagante null");
				_pagante = value;
			}
		}

		Spesa Spesa
		{
			get { return _spesa; }

			set
			{
				if (value == null)
					throw new ArgumentException("Spesa null");
				_spesa = value;
			}
		}

		IMetodoDiDivisione MetodoDivisione
		{
			get { return _metodoDivisione; }

			set
			{
				if (value == null)
					throw new ArgumentException("MetodoDivisione null");
				_metodoDivisione = value;
			}
		}

		// Viene richiamato dalla spesa ogni volta che si crea una nuova spesa
		// per popolare la lista dei movimenti dell'utente
		public void generaMovimenti(Parti parti)
		{
			foreach (var item in MetodoDivisione.DividiSpesa(Spesa.Importo, parti))
			{
				if (item.Key.Equals(Pagante))
					continue;
				else
				{
					Movimento movimento = new Movimento(item.Key, Pagante, item.Value, Spesa);
					movimento.Sorgente.AggiungiMovimentoDiDenaro(movimento);
					movimento.Destinazione.AggiungiMovimentoDiDenaro(movimento);
				}
			}
		}
	}
}
