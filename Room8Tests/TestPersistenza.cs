using System;
using NUnit.Framework;
using Room8;

namespace Room8Tests
{
    [TestFixture()]
    public class TestPeristenza
    {
        [Test()]
        public void Test1()
        {
            GestoreUtenti dati = GestoreUtenti.Instance;
            IPersistenza persistenzaXml = new PersistenzaXML("inizializzazione.xml");
            dati.Carica(persistenzaXml);

            Assert.AreEqual(dati.Utenti.Count, 6);
            Assert.AreEqual(dati.Gruppi.Count, 3);

        }
    }
}

