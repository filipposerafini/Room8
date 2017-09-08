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
				throw new ArgumentNullException("utente");

			if (Utenti.Contains(utente))
				throw new ArgumentException("Utente già presente", "membro");

			_utenti.Add(utente);
			utente.AggiungiMembriGruppo(this);
		}

		public void RimuoviMembro(Utente utente)
		{
			if (utente == null)
				throw new ArgumentNullException("utente");

			if (!_utenti.Remove(utente))
				throw new ArgumentException("utente non presente");
			// aggiorniamo anche la lista di gruppi di cui l'utente è membro
			utente.RimuoviMembriGruppo(this);
		}
	}
}
