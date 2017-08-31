using System;
using System.Collections.Generic;

namespace Room8
{
	public class MembriGruppo
	{
		private readonly Gruppo _gruppo;
		private readonly List<Utente> _utenti;

		public MembriGruppo(Gruppo gruppo)
		{
			this._gruppo = gruppo;
			this._utenti = new List<Utente>();
		}

		public Gruppo Gruppo
		{
			get { return _gruppo; }
		}

		public IList<Utente> Utenti
		{
			get { return _utenti.AsReadOnly(); }
		}

		public void AggiungiMembro(Utente utente)
		{
			if (utente == null)
				throw new ArgumentException("Utente null");
			
			if (_utenti.Contains(utente))
				throw new ArgumentException("Utente già presente");
			
			_utenti.Add(utente);
			utente.AggiungiMembriGruppo(this);
		}

		public void RimuoviMembro(Utente utente)
		{
			if (utente == null)
				throw new ArgumentException("Utente null");

			if (!_utenti.Contains(utente))
				throw new ArgumentException("Utente non presente");

			_utenti.Remove(utente);
			utente.RimuoviMembriGruppo(this);
		}
	}
}
