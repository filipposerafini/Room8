using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace Room8
{
	public class Utente
	{
        private static readonly string FOTODEFAULT = "../../Resources/Images/defaultperson.png";
		private string _mail;
		private string _password;
		private string _nome;
		private string _cognome;
		private string _telefono;
		private string _foto;
		// lista di gruppi di cui l'utente fa parte
        private readonly List<Gruppo> _gruppi = new List<Gruppo>();
        private readonly List<MovimentoDiDenaro> _movimentiDiDenaro = new List<MovimentoDiDenaro>();

		public Utente(string mail, string password, string nome, string cognome, string telefono, string foto)
		{
			Mail = mail;
			Password = password;
			Nome = nome;
			Cognome = cognome;
			Telefono = telefono;
			Foto = foto;
		}

		public string Mail
		{
			get { return _mail; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Inserisci la mail", "mail");
				if (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
					throw new ArgumentException("Inserisci una mail valida", "mail");
				_mail = value;
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Inserisci la password", "password");
				if (!Regex.IsMatch(value, @".{8,}"))
					throw new ArgumentException("La password deve avere almeno 8 caratteri", "password");
				_password = value;
			}
		}

		public string Nome
		{
			get { return _nome; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Inserisci un nome", "nome");
				if (!Regex.IsMatch(value, @"[A-z]{1,}"))
					throw new ArgumentException("Inserisci un nome valido", "nome");
				_nome = value;
			}
		}

		public string Cognome
		{
			get { return _cognome; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Inserisci un cognome", "cognome");
				if (!Regex.IsMatch(value, @"[A-z]{1,}"))
					throw new ArgumentException("Inserisci un cognome valido", "cognome");
				_cognome = value;
			}
		}

        public string Telefono
        {
            get { return _telefono; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Inserisci un numero di telefono", "telefono");
				if (!Regex.IsMatch(value, @"\+?[0-9]{8,}"))
					throw new ArgumentException("Inserisci un numero di telefono valido", "telefono");
				_telefono = value;
			}
        }

		public string Foto
		{
			get { return _foto; }

			set
			{
				if (string.IsNullOrEmpty(value))
					_foto = FOTODEFAULT;
				else if (!(value.EndsWith(".jpg") || value.EndsWith(".png")))
					throw new ArgumentException("Inserisci una foto valida", "foto");
				else
					_foto = value;
			}
		}

		public List<Gruppo> Gruppi
		{
			get { return _gruppi; }
		}

		public List<MovimentoDiDenaro> MovimentiDiDenaro
		{
			get { return _movimentiDiDenaro; }
		}

		// Aggiungi e Rimuovi membri dovrebbe essere possibile solo da Gruppo
		public void AggiungiGruppo(Gruppo gruppo)
		{
			if (gruppo == null)
				throw new ArgumentException("membriGruppo null");

			_gruppi.Add(gruppo);
		}

		public void RimuoviGruppo(Gruppo gruppo)
		{
			if (gruppo == null)
				throw new ArgumentException("membriGruppo null");

			_gruppi.Remove(gruppo);
		}

		public decimal CalcolaSituazione(Utente amico)
		{
			// ritorna l'ammontare totale a Credito/debito con utente 'amico'
			if (amico == null)
				throw new ArgumentException("amico null");
			decimal result = 0;
			foreach (var movimento in MovimentiDiDenaro.Where(
				mov => mov.Destinazione.Equals(amico) || mov.Sorgente.Equals(amico)))
			{
				if (movimento.Sorgente.Equals(amico) && movimento.Destinazione.Equals(this))
					result += movimento.Importo;
				else if (movimento.Sorgente.Equals(this) && movimento.Destinazione.Equals(amico))
					result -= movimento.Importo;
			}

			// Risultato negativo --> Credito
			// Risultato positivo --> Debito

			return result;
		}

		public decimal CalcolaSituazioneGruppo(Utente amico, Gruppo gruppo)
		{
			// come calcolaSituazione ma limitato ai movimenti nel gruppo 'gruppo' 
			if (amico == null)
				throw new ArgumentException("amico null");
			if (gruppo == null)
				throw new ArgumentException("amico null");

			decimal result = 0;
			foreach (var movimento in MovimentiDiDenaro.Where(
				mov => mov.Destinazione.Equals(amico) || mov.Sorgente.Equals(amico)))
			{
                if (movimento is Movimento && (movimento as Movimento).Spesa.SpeseGruppo.Gruppo.Equals(gruppo))
				{
					if (movimento.Sorgente.Equals(amico) && movimento.Destinazione.Equals(this))
						result += movimento.Importo;
					else if (movimento.Sorgente.Equals(this) && movimento.Destinazione.Equals(amico))
						result -= movimento.Importo;
				}
				else
					continue;
			}

			// Risultato negativo --> Credito
			// Risultato positivo --> Debito

			return result;
		}

		public decimal CalcolaBilancio(Gruppo gruppo)
		{
			// ritorna l'ammontare totale a credito/debito con l'intero gruppo
			if (gruppo == null)
				throw new ArgumentException("gruppo null");
			if (!gruppo.MembriGruppo.Contains(this))
				throw new ArgumentException("utente non appartenente al gruppo");

			decimal result = 0;

			result = gruppo.MembriGruppo.Sum(u => this.CalcolaSituazioneGruppo(u, gruppo));
			return result;
		}

		public List<Utente> Amici()
		{
			return Gruppi.SelectMany(g => g.MembriGruppo).Distinct().Where(u => !u.Equals(this)).ToList();
		}
	}
}
