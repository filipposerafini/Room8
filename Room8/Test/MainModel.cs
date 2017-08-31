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

			Spesa spesa = new Spesa(gruppo1.SpeseGruppo, "Spesa1", 100, utente1, "Equa", DateTime.Now);

			//pagamento.Parti.ImpostaParte(utente1, 20);
			//pagamento.Parti.ImpostaParte(utente2, 40);
			//pagamento.Parti.ImpostaParte(utente3, 40);

			gruppo1.SpeseGruppo.AggiungiSpesa(spesa);
			var prodotto = new Prodotto("Prova", 3);

			Console.WriteLine(utente1.calcolaSituazione(utente2));

			Saldo saldo = new Saldo(utente2, utente1, 66, DateTime.Now);
			utente1.AggiungiMovimentoDiDenaro(saldo);
			utente2.AggiungiMovimentoDiDenaro(saldo);

			Console.WriteLine(utente1.calcolaSituazione(utente2));
			Console.WriteLine(utente1.calcolaSituazione(utente3));
		}
	}
}
