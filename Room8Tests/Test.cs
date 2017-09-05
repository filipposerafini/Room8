using NUnit.Framework;
using System;
using Room8;
using System.Collections.Generic;

namespace Room8Tests
{
	//Spese gruppo
	[TestFixture()]
	public class TestSpesa
	{
		[Test()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestUtentePagante()
		{
            Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1", null);
            Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2", null);
			Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3", null);

			Gruppo gruppo1 = new Gruppo("Gruppo1");

			gruppo1.AggiungiMembro(utente1);
			gruppo1.AggiungiMembro(utente2);

			// Se utente pagante non è nel gruppo devo lanciare un eccezione
			Spesa spesa = new Spesa(gruppo1, "Spesa1", 100, utente3, "Equa", DateTime.Now);

			gruppo1.SpeseGruppo.AggiungiSpesa(spesa);

			Console.WriteLine(utente1.calcolaSituazione(utente2));

			Saldo saldo = new Saldo(utente2, utente1, 66, DateTime.Now);

			saldo.AggiungiMovimentoDiDenaro();

		}

		[Test()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestPercentuale()
        {
            Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1", null);
            Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2", null);
            Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3", null);

			Gruppo gruppo1 = new Gruppo("Gruppo1");

			gruppo1.AggiungiMembro(utente1);
			gruppo1.AggiungiMembro(utente2);
			gruppo1.AggiungiMembro(utente3);

			Spesa spesa = new Spesa(gruppo1, "Spesa1", 100, utente3, "Percentuale", DateTime.Now);

			//Se scelgo percentuale o quote devo impostare le parti, se no eccezione

			spesa.Parti.ImpostaParte(utente1, 10);
			spesa.Parti.ImpostaParte(utente2, 50);
			spesa.Parti.ImpostaParte(utente3, 30);

			//under 100, spesa errata
			gruppo1.SpeseGruppo.AggiungiSpesa(spesa);
			gruppo1.SpeseGruppo.RimuoviSpesa(spesa);

		}

		[Test()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestQuote()
		{
            Utente utente1 = new Utente("user1@mail.com", "password1", "nome1", "cognome1", null);
            Utente utente2 = new Utente("user2@mail.com", "password2", "nome2", "cognome2", null);
            Utente utente3 = new Utente("user3@mail.com", "password3", "nome3", "cognome3", null);

			Gruppo gruppo1 = new Gruppo("Gruppo1");

			gruppo1.AggiungiMembro(utente1);
			gruppo1.AggiungiMembro(utente2);
			gruppo1.AggiungiMembro(utente3);

			Spesa spesa = new Spesa(gruppo1, "Spesa1", 100, utente3, "Per quote", DateTime.Now);

			gruppo1.SpeseGruppo.AggiungiSpesa(spesa);
			gruppo1.SpeseGruppo.RimuoviSpesa(spesa);

		}

		[Test()]
		public void TestMovimenti()
		{
            GestoreUtenti dati = GestoreUtenti.Instance;

			Gruppo gruppo1 = dati.Gruppi[0];
			Utente utente1 = gruppo1.MembriGruppo[0];
			Utente utente2 = gruppo1.MembriGruppo[1];
			Utente utente3 = gruppo1.MembriGruppo[2];

			Spesa spesa1 = new Spesa(gruppo1, "1Spesa", 80, utente3, "Per quote", DateTime.Now);
			spesa1.Parti.ImpostaParte(utente1, 1);
			spesa1.Parti.ImpostaParte(utente2, 2);
			spesa1.Parti.ImpostaParte(utente3, 5);

			gruppo1.SpeseGruppo.AggiungiSpesa(spesa1);

			Spesa spesa2 = new Spesa(gruppo1, "2Spesa", 100, utente1, "Percentuale", DateTime.Now);
			spesa2.Parti.ImpostaParte(utente1, 60);
			spesa2.Parti.ImpostaParte(utente2, 20);
			spesa2.Parti.ImpostaParte(utente3, 20);

			gruppo1.SpeseGruppo.AggiungiSpesa(spesa2);

			decimal result = utente1.calcolaSituazione(utente3);
			Assert.AreEqual(result, -10);

			gruppo1.SpeseGruppo.RimuoviSpesa(spesa2);
			result = utente1.calcolaSituazione(utente3);
			Assert.AreEqual(result, 10);

			Saldo saldo = new Saldo(utente1, utente3, 10, DateTime.Now);
			saldo.AggiungiMovimentoDiDenaro();
			result = utente1.calcolaSituazione(utente3);
			Assert.AreEqual(result, 0);

			saldo = (Saldo)utente1.MovimentiDiDenaro.Find(x => x is Saldo);
			saldo.ModificaMovimentoDiDenaro(new Saldo(utente1, utente3, 20, DateTime.Now));
			result = utente1.calcolaSituazione(utente3);
			Assert.AreEqual(result, -10);

		}

		[Test()]
		[ExpectedException(typeof(ArgumentException))]
		public void TestBilancio()
		{
            GestoreUtenti dati = GestoreUtenti.Instance;

			Gruppo gruppo1 = dati.Gruppi[0];
			Utente utente1 = gruppo1.MembriGruppo[0];
			Utente utente2 = gruppo1.MembriGruppo[1];
			Utente utente3 = gruppo1.MembriGruppo[2];
			Utente utente4 = dati.Gruppi[1].MembriGruppo[0];

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
			gruppo1.SpeseGruppo.AggiungiSpesa(spesa2);

			bilancio = utente1.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, -20);
			bilancio = utente2.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, -20);
			bilancio = utente3.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 40);

			Spesa spesa3 = new Spesa(gruppo1, "Spesa3", 60, utente3, "Equa", DateTime.Now);
			gruppo1.SpeseGruppo.AggiungiSpesa(spesa3);

			bilancio = utente1.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 0);
			bilancio = utente2.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 0);
			bilancio = utente3.calcolaBilancio(gruppo1);
			Assert.AreEqual(bilancio, 0);
		}

		[Test()]
		public void TestGestoreUtenti()
		{
            GestoreUtenti dati = GestoreUtenti.Instance;

			Utente utenteDoppio = new Utente("user1@mail.com", "abc", "xxx", "xxx",null);
            Assert.Throws<ArgumentException>(() => dati.AggiugniUtente(utenteDoppio));

			Utente utenteOk = new Utente("utneteOK@mail.com", "abc", "yyy", "yyy",null);
            dati.AggiugniUtente(utenteOk);

            dati.AggiugniUtente(utenteOk);
			Gruppo gruppoConNuovi = new Gruppo("GruppoN");
			gruppoConNuovi.AggiungiMembro(utenteOk);
			dati.AggiungiGruppo(gruppoConNuovi);

            Assert.IsNotNull(dati.VerificaPassword("utneteOK@mail.com", "abc"));
            Assert.IsNull(dati.VerificaPassword("utneteOK@mail.com", "abcd"));

			Assert.Throws<ArgumentException>(() => dati.VerificaPassword("emailCheNonEsiste", "aloha"));
		}
	}
}
