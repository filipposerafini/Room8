using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Room8
{
    public class PersistenzaXML : IPersistenza 
    {
        private XmlDocument _document;

        private readonly List<Gruppo> _gruppi = new List<Gruppo>();
        private readonly List<Utente> _utenti = new List<Utente>();
        private bool caricato = false;
        private string _nomefile;

        public PersistenzaXML(string nomefile)
        {
            _document = new XmlDocument();
            _nomefile = nomefile;
            try
            {
                _document.Load(nomefile);
            }
            catch(FileNotFoundException)
            {
                FileStream file = File.Create(nomefile);
                file.Close();
                XmlNode node = _document.CreateXmlDeclaration("1.0","","");
                _document.AppendChild(node);
                XmlNode root = _document.CreateElement("Gruppi");
                _document.AppendChild(root);
                _document.Save(nomefile);
                caricato = true;
            }
        }

        public XmlDocument Document
        {
            get { return _document; }
        }

        public void Salva(GestoreUtenti dati)
        {
            //in append salvare le modifiche? 
            //o salvo tutto?
//            dati.Utenti;
//            dati.Gruppi;
        }

        public List<Utente> CaricaUtenti()
        {
            Carica();
            return _utenti;
        }

        public List<Gruppo> CaricaGruppi()
        {
            Carica();
            return _gruppi;
        }

        private void Carica()
        {
            if (caricato)
                return;
            
            Gruppo nuovoGruppo = null;
            Utente nuovoUtente = null;

            XmlNodeList listaGruppi = _document.SelectNodes("/Gruppi/Gruppo");


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
            caricato = true;
        }

        private Utente LeggiUtente(XmlNode utenteNode)
        {
            string nome = "";
            string cognome = "";
            string email = "";
            string password = "";
            string telefono = "33333333333";
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
                else if (utenteAtt.Name.Equals("Foto"))
                {
                    foto = utenteAtt.InnerText;
                }
            }

            result = new Utente(email, password, nome, cognome, telefono, foto);
            _utenti.Add(result);
            return result;
        }
    }
}

