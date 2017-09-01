using System;
using System.Collections.Generic;

namespace Room8
{
	public class DatiIniziali
	{
		private static DatiIniziali datiIniziali;
		private List<Gruppo> _gruppi;
		private List<Utente> _utenti;

		private DatiIniziali ()
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

			gruppo1.MembriGruppo.AggiungiMembro (utente1);
			gruppo1.MembriGruppo.AggiungiMembro (utente2);
			gruppo1.MembriGruppo.AggiungiMembro (utente3);

			gruppo2.MembriGruppo.AggiungiMembro (utente4);
			gruppo2.MembriGruppo.AggiungiMembro (utente5);

			gruppo3.MembriGruppo.AggiungiMembro (utente1);
			gruppo3.MembriGruppo.AggiungiMembro (utente2);
			gruppo3.MembriGruppo.AggiungiMembro (utente3);
			gruppo3.MembriGruppo.AggiungiMembro (utente4);
			gruppo3.MembriGruppo.AggiungiMembro (utente5);

			_gruppi = new List<Gruppo>();
			_gruppi.Add (gruppo1);
			_gruppi.Add (gruppo2);
			_gruppi.Add (gruppo3);
		}

		public static DatiIniziali Istanza
		{
			get
			{
				if(datiIniziali == null)
				{
					datiIniziali = new DatiIniziali();
				}
				return datiIniziali;
			}
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
	}
}

