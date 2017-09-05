using System;
using System.Collections.Generic;
using System.Xml;

namespace Room8
{
    public class GestoreUtenti
    {
        private static GestoreUtenti _instance;
        private readonly List<Gruppo> _gruppi = new List<Gruppo>();
        private readonly List<Utente> _utenti = new List<Utente>();

        private GestoreUtenti()
        {
            // Lettura degli utenti registrati da file xml 
            XmlDocument doc = new XmlDocument();
            doc.Load("inizializzazione.xml");

            string nomeGruppo = "";
            Utente nuovoUtente;

            XmlNodeList listaGruppi = doc.SelectNodes("/Gruppi/Gruppo");

            foreach (XmlNode gruppoNode in listaGruppi)
            {
                foreach (XmlNode gruppoAtt in gruppoNode)
                {
                    if (gruppoAtt.Name.Equals("Nome"))
                    {
                        nomeGruppo = gruppoAtt.InnerText;
                        _gruppi.Add(new Gruppo(nomeGruppo));
                    }
                    if (gruppoAtt.Name.Equals("Utenti"))
                    {
                        foreach (XmlNode utente in gruppoAtt)
                        {
                            nuovoUtente = new Utente(utente);
                            if (!_utenti.Exists(x => x.Equals(nuovoUtente)))
                                _utenti.Add(nuovoUtente);
                            _gruppi.Find(x => x.Nome.Equals(nomeGruppo)).AggiungiMembro(nuovoUtente);
                        }
                    }
                }
            }
        }

        public static GestoreUtenti Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GestoreUtenti();
                return _instance;
            }
        }

        public IList<Gruppo> Gruppi
        {
            get
            {
                return _gruppi.AsReadOnly();
            }
        }

        public IList<Utente> Utenti
        {
            get
            {
                return _utenti.AsReadOnly();
            }
        }

        public void AggiugniUtente(Utente utente)
        {
            if (_utenti.Exists(x => x.Email.Equals(utente.Email)))
            {
                throw new ArgumentException("Utente già presente");
            }
            _utenti.Add(utente);
        }

        public void RimuoviUtente(Utente utente)
        {
            if (!_utenti.Contains(utente))
            {
                throw new ArgumentException("Utente non presente, eliminazione fallita");
            }
            _utenti.Remove(utente);
        }

        public void AggiungiGruppo(Gruppo gruppo)
        {
            if ((this.Gruppi as List<Gruppo>).Exists(x => x.Id.Equals(gruppo.Id)))
            {
                throw new ArgumentException("Utente già presente");
            }

            foreach (var utente in gruppo.MembriGruppo)
            {
                if (!_utenti.Exists(x => x.Email.Equals(utente.Email)))
                {
                    _utenti.Add(utente);
                }
            }
            this.Gruppi.Add(gruppo);
        }

        public void RimuoviGruppo(Gruppo gruppo)
        {
            if (!this.Gruppi.Contains(gruppo))
            {
                throw new ArgumentException("Gruppo non presente, eliminazione fallita");
            }
            this.Gruppi.Remove(gruppo);
        }

        public Utente VerificaPassword(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("Inserisci un indirizzo email");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Inserisci la password");
			
            Utente utente = _utenti.Find(x => x.Email.Equals(email));

            if (utente == null)
                throw new ArgumentException("Utente non presente");

            if (utente.Password.Equals(password))
                return utente;
            else
                throw new ArgumentException("Password errata");
        }
    }
}

