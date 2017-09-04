using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Room8
{
	public class Utente
	{
		private static readonly string FOTODEFAULT = "/pathto/fotodefault.jpg";
		private readonly string _email;
		private readonly string _password;
		private readonly string _nome;
		private readonly string _cognome;
		private string _foto;
		// lista di gruppi di cui l'utente fa parte
		private readonly List<Gruppo> _gruppi;
		private readonly List<MovimentoDiDenaro> _movimentiDiDenaro;

		public Utente(string email, string password, string nome, string cognome)
		{
			if (String.IsNullOrEmpty(email))
				throw new ArgumentException("email is null or empty");
			if (String.IsNullOrEmpty(password))
				throw new ArgumentException("password is null or empty");
			if (String.IsNullOrEmpty(nome))
				throw new ArgumentException("nome is null or empty");
			if (String.IsNullOrEmpty(cognome))
				throw new ArgumentException("cognome is null or empty");

			this._email = email;
			this._password = password;
			this._nome = nome;
			this._cognome = cognome;
			this._foto = FOTODEFAULT;
			this._gruppi = new List<Gruppo>();
			this._movimentiDiDenaro = new List<MovimentoDiDenaro>();
		}

		public Utente(string email, string password, string nome, string cognome, string foto)
			: this(email, password, nome, cognome)
		{
			if (String.IsNullOrEmpty(foto))
				throw new ArgumentException("foto is null or empty");
			this._foto = foto;
		}

		public string Email
		{
			get { return _email; }
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

		public void AggiungiMovimentoDiDenaro(MovimentoDiDenaro movimento)
		{
			if (movimento == null)
				throw new ArgumentException("movimento null");

			_movimentiDiDenaro.Add(movimento);
			movimento.Destinazione.AggiungiMovimentoDiDenaro (movimento);
		}

		public void RimuoviMovimentoDiDenaro(MovimentoDiDenaro movimento)
		{
			if (movimento == null)
				throw new ArgumentException("movimento null");

			if (!_movimentiDiDenaro.Remove(movimento))
				throw new ArgumentException("movimento non presente");
			if (!movimento.Destinazione.MovimentiDiDenaro.Remove(movimento))
				throw new ArgumentException("movimento non presente");
		}

		public void ModificaMovimentoDiDenaro(MovimentoDiDenaro daModificare, MovimentoDiDenaro nuovoMovimento)
		{
			if (daModificare == null)
				throw new ArgumentException("daModificare null");
			if (nuovoMovimento == null)
				throw new ArgumentException("saldo null");
			
			RimuoviMovimentoDiDenaro(daModificare);
			AggiungiMovimentoDiDenaro(nuovoMovimento);
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
				if (movimento is Movimento && (movimento as Movimento).Spesa.Gruppo.Equals(gruppo))
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

			result = gruppo.MembriGruppo.Sum(u => this.calcolaSituazioneGruppo(u,gruppo));
			return result;
		}


	}
}
