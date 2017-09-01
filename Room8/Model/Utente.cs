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
		private readonly List<MembriGruppo> _membriGruppo;
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
			this._membriGruppo = new List<MembriGruppo>();
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

		public List<MembriGruppo> MembriGruppo
		{
			get { return _membriGruppo; }
		}

		public List<MovimentoDiDenaro> MovimentiDiDenaro
		{
			get { return _movimentiDiDenaro; }
		}

		public void AggiungiMembriGruppo(MembriGruppo membriGruppo)
		{
			if (membriGruppo == null)
				throw new ArgumentException("membriGruppo null");

			_membriGruppo.Add(membriGruppo);
		}

		public void RimuoviMembriGruppo(MembriGruppo membriGruppo)
		{
			if (membriGruppo == null)
				throw new ArgumentException("membriGruppo null");

			_membriGruppo.Remove(membriGruppo);
		}

		public void AggiungiMovimentoDiDenaro(MovimentoDiDenaro movimento)
		{
			if (movimento == null)
				throw new ArgumentException("movimento null");

			_movimentiDiDenaro.Add(movimento);
		}

		public void RimuoviMovimentoDiDenaro(MovimentoDiDenaro movimento)
		{
			if (movimento == null)
				throw new ArgumentException("movimento null");

			if (!_movimentiDiDenaro.Remove(movimento))
				throw new ArgumentException("movimento non presente");
		}

		public void AggiungiSaldo(Utente destinazione, decimal importo, DateTime data)
		{

			if (destinazione == null || importo == null || data == DateTime.MinValue)
				throw new ArgumentException("saldo null");
			Saldo saldo = new Saldo (this, destinazione, importo, data);

			this.AggiungiMovimentoDiDenaro(saldo);
			saldo.Destinazione.AggiungiMovimentoDiDenaro(saldo);
		}


		public void ModificaSaldo(Saldo daModificare, Utente destinazione, decimal importo, DateTime data)
		{
			if (daModificare == null)
				throw new ArgumentException("daModificare null");
			if (destinazione == null || importo == null || data == DateTime.MinValue)
				throw new ArgumentException("saldo null");
			
			RimuoviSaldo(daModificare);
			AggiungiSaldo(destinazione, importo, data);
		}

		public void RimuoviSaldo(Saldo saldo)
		{
			if (saldo == null)
				throw new ArgumentException("saldo null");

			saldo.Sorgente.RimuoviMovimentoDiDenaro(saldo);
			saldo.Destinazione.RimuoviMovimentoDiDenaro(saldo);
		}

		public decimal calcolaSituazione(Utente amico)
		{
			decimal res = 0;
			foreach (var movimento in MovimentiDiDenaro.Where(
				mov => mov.Destinazione.Equals(amico) || mov.Sorgente.Equals(amico)))
			{
				if (movimento.Sorgente.Equals(amico) && movimento.Destinazione.Equals(this))
					res += movimento.Importo;
				else if (movimento.Sorgente.Equals(this) && movimento.Destinazione.Equals(amico))
					res -= movimento.Importo;
			}

			// Risultato negativo --> Credito
			// Risultato positivo --> Debito

			return res;
		}
	}
}
