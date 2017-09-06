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

            Gruppo nuovoGruppo = null;
            Utente nuovoUtente = null;

            XmlNodeList listaGruppi = doc.SelectNodes("/Gruppi/Gruppo");

            foreach (XmlNode gruppoNode in listaGruppi)
            {
                foreach (XmlNode gruppoAtt in gruppoNode)
                {
                    if (gruppoAtt.Name.Equals("Nome"))
                    {
                        nuovoGruppo = new Gruppo(gruppoAtt.InnerText);
                        _gruppi.Add(nuovoGruppo);
                    }
                    if (gruppoAtt.Name.Equals("Utenti"))
                    {
                        foreach (XmlNode utente in gruppoAtt)
                        {
                            nuovoUtente = this.LeggiUtente(utente);
                            nuovoGruppo.AggiungiMembro(nuovoUtente);
                        }
                    }
                }
            }

        }

        private Utente LeggiUtente(XmlNode utenteNode)
        {
            string nome = "";
            string cognome = "";
            string email = "";
            string password = "";
			string telefono = "";
			string foto = "";

            Utente result = null;

            if (utenteNode == null)
            {
                throw new ArgumentException("UtenteNode è null");
            }
            foreach (XmlNode utenteAtt in utenteNode.ChildNodes)
            {
                if (utenteAtt.Name.Equals("Nome"))
                {
                    nome = utenteAtt.InnerText;
                }
                else if (utenteAtt.Name.Equals("Cognome"))
                {
                    cognome = utenteAtt.InnerText;
                }
                else if (utenteAtt.Name.Equals("Email"))
                {
                    result = _utenti.Find(u => u.Mail.Equals(utenteAtt.InnerText));
                    if(result != null)
                        return result;
                    email = utenteAtt.InnerText;
                }
                else if (utenteAtt.Name.Equals("Password"))
                {
                    password = utenteAtt.InnerText;
                }
            }
            foto = null;
			result = new Utente(email, password, nome, cognome, "333333333", foto);
            _utenti.Add(result);
            return result;
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
            if (_utenti.Exists(x => x.Mail.Equals(utente.Mail)))
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
                if (!_utenti.Exists(x => x.Mail.Equals(utente.Mail)))
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

        public Utente VerificaPassword(string mail, string password)
        {
            if (string.IsNullOrEmpty(mail))
                throw new ArgumentException("Inserisci un indirizzo email", "mail");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Inserisci la password", "password");
			
            Utente utente = _utenti.Find(x => x.Mail.Equals(mail));

            if (utente == null)
                throw new ArgumentException("Utente non presente", "mail");

            if (utente.Password.Equals(password))
                return utente;
            else
                throw new ArgumentException("Password errata", "password");
        }
    }
}

