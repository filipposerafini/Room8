using System;
using System.Collections.Generic;
using System.Xml;

namespace Room8
{
    public class GestoreUtenti
    {
        private static GestoreUtenti _instance;
        private List<Gruppo> _gruppi = new List<Gruppo>();
        private List<Utente> _utenti = new List<Utente>();

        private GestoreUtenti()
        {
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

        // scegli la tua modalià di persistenza
        public void Salva(IPersistenza tipoPersistenza)
        {
            tipoPersistenza.Salva(this);
        }

        // scegli la tua modalià di persistenza
        public void Carica(IPersistenza tipoPersistenza)
        {
            _gruppi = tipoPersistenza.CaricaGruppi();
            _utenti = tipoPersistenza.CaricaUtenti();
        }
    }
}

