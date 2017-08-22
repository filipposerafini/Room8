using System;
using System.Collections.Generic;

namespace Room8
{
	public class MainModel
	{
		static void Main() 
		{
			Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1");
			Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2");
			Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3");

			Gruppo gruppo1 = new Gruppo("Gruppo1");

			gruppo1.MembriGruppo.AggiungiMembro(utente1);
			gruppo1.MembriGruppo.AggiungiMembro(utente2);
			gruppo1.MembriGruppo.AggiungiMembro(utente3);

			Spesa spesa = new Spesa(gruppo1.SpeseGruppo, "Spesa1", 60, DateTime.Now);

			Dictionary<Utente, int> div = new Dictionary<Utente, int>();
			div.Add(utente1, 33);
			div.Add(utente2, 33);
			div.Add(utente3, 33);
			Parti parti = new Parti(div);

			GestorePagamento g = new GestorePagamento(spesa, utente1, "Percentuale");

			g.generaMovimenti(parti);

			Console.WriteLine(utente1.Nome + " deve ricevere " + utente1.calcolaSituazione(utente2) + " euro da " + utente2.Nome);
		}
	}
}
