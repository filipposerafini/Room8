using System;

namespace Room8
{
    public class Commento
    {
        private readonly string _testo;
        private readonly Utente _autore;
        private readonly DateTime _data;

        public Commento(string testo, Utente autore)
        {
            if (string.IsNullOrEmpty(testo))
                throw new ArgumentException("Inserisci un testo");
            if (autore == null)
                throw new ArgumentNullException("autore");
            _data = DateTime.Now;
            _testo = testo;
            _autore = autore;
        }

        public string Testo
        {
            get { return _testo; }
        }

        public Utente Autore
        {
            get { return _autore; }
        }

        public string NomeAutore
        {
            get { return Autore.Nome; }
        }

        public DateTime Data
        {
            get { return _data; }
        }
    }
}

