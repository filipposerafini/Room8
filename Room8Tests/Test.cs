using NUnit.Framework;
using System;
using Room8;
using System.Collections.Generic;

namespace Room8Tests
{
	//Spese gruppo
	[TestFixture ()]
	public class TestSpesa	
	{
		[Test ()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestUtentePagante ()
		{
			Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1");
			Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2");
			Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3");

			Gruppo gruppo1 = new Gruppo("Gruppo1");

			gruppo1.MembriGruppo.AggiungiMembro(utente1);
			gruppo1.MembriGruppo.AggiungiMembro(utente2);

			// Se utente pagante non è nel gruppo devo lanciare un eccezione
			Spesa spesa = new Spesa(gruppo1, "Spesa1", 100, utente3, "Equa", DateTime.Now);

			gruppo1.SpeseGruppo.AggiungiSpesa(spesa);

			Console.WriteLine(utente1.calcolaSituazione(utente2));

			Saldo saldo = new Saldo(utente2, utente1, 66, DateTime.Now);

			utente1.AggiungiMovimentoDiDenaro(saldo);
			utente2.AggiungiMovimentoDiDenaro(saldo);

		}

		[Test ()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestPercentuale ()
		{
			Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1");
			Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2");
			Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3");

			Gruppo gruppo1 = new Gruppo("Gruppo1");

			gruppo1.MembriGruppo.AggiungiMembro(utente1);
			gruppo1.MembriGruppo.AggiungiMembro(utente2);
			gruppo1.MembriGruppo.AggiungiMembro(utente3);

			Spesa spesa = new Spesa(gruppo1, "Spesa1", 100, utente3, "Percentuale", DateTime.Now);

			//Se scelgo percentuale o quote devo impostare le parti, se no eccezione

			spesa.Parti.ImpostaParte(utente1, 10);
			spesa.Parti.ImpostaParte(utente2, 50);
			spesa.Parti.ImpostaParte(utente3, 30);

			//under 100, spesa errata
			gruppo1.SpeseGruppo.AggiungiSpesa(spesa);
			gruppo1.SpeseGruppo.RimuoviSpesa(spesa);

		}

		[Test ()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestQuote ()
		{
			Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1");
			Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2");
			Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3");

			Gruppo gruppo1 = new Gruppo("Gruppo1");

			gruppo1.MembriGruppo.AggiungiMembro(utente1);
			gruppo1.MembriGruppo.AggiungiMembro(utente2);
			gruppo1.MembriGruppo.AggiungiMembro(utente3);

			Spesa spesa = new Spesa(gruppo1, "Spesa1", 100, utente3, "Per quote", DateTime.Now);

			gruppo1.SpeseGruppo.AggiungiSpesa(spesa);
			gruppo1.SpeseGruppo.RimuoviSpesa(spesa);

		}

		[Test ()]
		public void TestMovimenti ()
		{
			DatiIniziali dati = DatiIniziali.Istanza;

			Gruppo gruppo1 = dati.Gruppi[0];
			Utente utente1 = gruppo1.MembriGruppo.Utenti[0];
			Utente utente2 = gruppo1.MembriGruppo.Utenti[1];
			Utente utente3 = gruppo1.MembriGruppo.Utenti[2];

			Spesa spesa1 = new Spesa(gruppo1, "Spesa1", 60, utente3, "Per quote", DateTime.Now);
			spesa1.Parti.ImpostaParte(utente1, 1);
			spesa1.Parti.ImpostaParte(utente2, 2);
			spesa1.Parti.ImpostaParte(utente3, 3);

			gruppo1.SpeseGruppo.AggiungiSpesa (spesa1);

			Spesa spesa2 = new Spesa(gruppo1, "Spesa2", 100, utente1, "Percentuale", DateTime.Now);
			spesa2.Parti.ImpostaParte (utente1, 60);
			spesa2.Parti.ImpostaParte (utente2, 20);
			spesa2.Parti.ImpostaParte (utente3, 20);

			gruppo1.SpeseGruppo.AggiungiSpesa (spesa2);

			decimal result = (utente1).calcolaSituazione (utente3);
			Assert.AreEqual(result, -10);

			gruppo1.SpeseGruppo.RimuoviSpesa (spesa2);
			result = utente1.calcolaSituazione (utente3);
			Assert.AreEqual(result, 10);

			utente1.AggiungiSaldo(utente3,10,DateTime.Now);
			result = utente1.calcolaSituazione (utente3);
			Assert.AreEqual(result, 0);

			Saldo saldo = (Saldo) utente1.MovimentiDiDenaro.Find(x => x is Saldo);
			utente1.ModificaSaldo(saldo,utente3,20,DateTime.Now);
			result = utente1.calcolaSituazione(utente3);
			Assert.AreEqual(result, -10);

		}

		[Test()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestBilancio()
		{
			DatiIniziali dati = DatiIniziali.Istanza;

			Gruppo gruppo1 = dati.Gruppi[0];
			Utente utente1 = gruppo1.MembriGruppo.Utenti[0];
			Utente utente2 = gruppo1.MembriGruppo.Utenti[1];
			Utente utente3 = gruppo1.MembriGruppo.Utenti[2];
			Utente utente4 = dati.Gruppi[1].MembriGruppo.Utenti[0];

			Spesa spesa1 = new Spesa(gruppo1, "Spesa1", 60, utente1, "Equa", DateTime.Now);
			gruppo1.SpeseGruppo.AggiungiSpesa(spesa1);

			decimal bilancio = utente4.calcolaBilancio(gruppo1);

			bilancio = utente1.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, -40);
			bilancio = utente2.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 20);
			bilancio = utente3.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 20);

			Spesa spesa2 = new Spesa(gruppo1, "Spesa2", 60, utente2, "Equa", DateTime.Now);
			gruppo1.SpeseGruppo.AggiungiSpesa(spesa1);

			bilancio = utente1.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, -20);
			bilancio = utente2.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, -20);
			bilancio = utente3.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 40);

			Spesa spess3 = new Spesa(gruppo1, "Spesa3", 60, utente3, "Equa", DateTime.Now);
			gruppo1.SpeseGruppo.AggiungiSpesa(spesa1);

			bilancio = utente1.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 0);
			bilancio = utente2.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 0);
			bilancio = utente3.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 0);
		}
	}
}
