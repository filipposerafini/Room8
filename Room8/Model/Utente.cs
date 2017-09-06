using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace Room8
{
	public class Utente
	{
		private static readonly string FOTODEFAULT = "/pathto/fotodefault.jpg";
		private readonly string _mail;
		private readonly string _password;
		private readonly string _nome;
		private readonly string _cognome;
		private readonly string _telefono;
		private string _foto;
		// lista di gruppi di cui l'utente fa parte
        private readonly List<Gruppo> _gruppi = new List<Gruppo>();
        private readonly List<MovimentoDiDenaro> _movimentiDiDenaro = new List<MovimentoDiDenaro>();

		public Utente(string mail, string password, string nome, string cognome, string telefono, string foto)
		{
			if (string.IsNullOrEmpty(nome))
				throw new ArgumentException("Inserisci un nome", "nome");
			if (!Regex.IsMatch(nome, @"[A-z]{1,}"))
				throw new ArgumentException("Inserisci un nome valido", "nome");
			if (string.IsNullOrEmpty(cognome))
				throw new ArgumentException("Inserisci un cognome", "cognome");
            if (!Regex.IsMatch(cognome, @"[A-z]{1,}"))
				throw new ArgumentException("Inserisci un cognome valido", "cognome");
			if (string.IsNullOrEmpty(mail))
				throw new ArgumentException("Inserisci la mail", "mail");
			if (!Regex.IsMatch(mail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
				throw new ArgumentException("Inserisci una mail valida", "mail");
			if (string.IsNullOrEmpty(password))
				throw new ArgumentException("Inserisci la password", "password");
			if (!Regex.IsMatch(password, @".{8,}"))
				throw new ArgumentException("La password deve avere almeno 8 caratteri", "password");
			if (string.IsNullOrEmpty(telefono))
				throw new ArgumentException("Inserisci un numero di telefono", "telefono");
			if (!Regex.IsMatch(telefono, @"\+?[0-9]{8,}"))
				throw new ArgumentException("Inserisci un numero di telefono valido", "telefono");
			
            this._mail = mail;
			this._password = password;
			this._nome = nome;
			this._cognome = cognome;
			this._telefono = telefono;

			if (string.IsNullOrEmpty(foto))
				this._foto = FOTODEFAULT;
			else
				this._foto = foto;
		}

		public string Mail
		{
			get { return _mail; }
		}

		public string Password
		{
			get { return _password; }
		}

		public string Nome
		{
			get { return _nome; }
		}

		public string Cognome
		{
			get { return _cognome; }
		}

		public string Foto
		{
			get { return _foto; }

			set
			{
				if (String.IsNullOrEmpty(value))
					throw new ArgumentException("foto is null or empty");

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

		public decimal calcolaSituazione(Utente amico)
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

		public decimal calcolaSituazioneGruppo(Utente amico, Gruppo gruppo)
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

		public decimal calcolaBilancio(Gruppo gruppo)
		{
			// ritorna l'ammontare totale a credito/debito con l'intero gruppo
			if (gruppo == null)
				throw new ArgumentException("gruppo null");
			if (!gruppo.MembriGruppo.Contains(this))
				throw new ArgumentException("utente non appartenente al gruppo");

			decimal result = 0;

			result = gruppo.MembriGruppo.Sum(u => this.calcolaSituazioneGruppo(u, gruppo));
			return result;
		}

		public	List<Utente> Amici()
		{
			return Gruppi.SelectMany(g => g.MembriGruppo).Distinct().Where(u => !u.Equals(this)).ToList();
		}
	}
}
