using System;
using System.Collections.Generic;

namespace Room8
{
	public class GestoreUtenti
	{
		private List<Gruppo> _gruppi;
		private List<Utente> _utenti;

		public GestoreUtenti ()
		{
			Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1");
			Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2");
			Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3");
			Utente utente4 = new Utente("user4@mail.com", "password4", "nome4", "cognome4");
			Utente utente5 = new Utente("user5@mail.com", "password5", "nome5", "cognome5");
			Utente utente6 = new Utente("user6@mail.com", "password6", "nome6", "cognome6");

			Gruppo gruppo1 = new Gruppo("Gruppo1");
			Gruppo gruppo2 = new Gruppo("Gruppo2");
			Gruppo gruppo3 = new Gruppo("Gruppo3");

			gruppo1.AggiungiMembro (utente1);
			gruppo1.AggiungiMembro (utente2);
			gruppo1.AggiungiMembro (utente3);

			gruppo2.AggiungiMembro (utente4);
			gruppo2.AggiungiMembro (utente5);

			gruppo3.AggiungiMembro (utente1);
			gruppo3.AggiungiMembro (utente2);
			gruppo3.AggiungiMembro (utente3);
			gruppo3.AggiungiMembro (utente4);
			gruppo3.AggiungiMembro (utente5);

			_gruppi = new List<Gruppo>();
			_gruppi.Add (gruppo1);
			_gruppi.Add (gruppo2);
			_gruppi.Add (gruppo3);

			_utenti = new List<Utente> ();
			_utenti.Add (utente1);
			_utenti.Add (utente2);
			_utenti.Add (utente3);
			_utenti.Add (utente4);
			_utenti.Add (utente5);
			_utenti.Add (utente6);
		}
			
		public List<Gruppo> Gruppi
		{
			get
			{
				return _gruppi;
			}
		}

		public List<Utente> Utenti
		{
			get
			{
				return _utenti;
			}
		}

		public void AggiugniUtnete(Utente utente)
		{
			if( _utenti.Exists( x => x.Email.Equals(utente.Email)))
			{
				throw new ArgumentException ("Utente già presente");
			}
			_utenti.Add (utente);
		}

		public void RimuoviUtnete(Utente utente)
		{
			if(!_utenti.Contains(utente))
			{
				throw new ArgumentException ("Utente non presente, eliminazione fallita");
			}
			_utenti.Remove (utente);
		}

		public void AggiungiGruppo(Gruppo gruppo)
		{
			if( this.Gruppi.Exists( x => x.Id.Equals(gruppo.Id)))
			{
				throw new ArgumentException ("Utente già presente");
			}

			foreach (var utente in gruppo.MembriGruppo) 
			{
				if (!_utenti.Exists( x => x.Email.Equals(utente.Email)))
				{
					_utenti.Add (utente);
				}
			}
			this.Gruppi.Add (gruppo);
		}

		public void RimuoviGruppo(Gruppo gruppo)
		{
			if(!this.Gruppi.Contains(gruppo))
			{
				throw new ArgumentException ("Gruppo non presente, eliminazione fallita");
			}
			this.Gruppi.Remove (gruppo);
		}

		public bool VerificaPassword(string email, string password)
		{
			Utente utente = _utenti.Find (x => x.Email.Equals (email));

			if (utente == null) 
			{
				throw new ArgumentException ("Utente non presente, verifica fallita");
			}

			if (utente.Password.Equals (password))
				return true;
			else
				return false;
		}
	}
}

