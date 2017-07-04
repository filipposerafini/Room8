using System;
using System.Collections.Generic;

namespace Room8
{
	public class Utente
	{
		private readonly string _email;
		private readonly string _password;
		private readonly string _nome;
		private readonly string _cognome;
		private string _foto;
		private List<Gruppo> gruppi;
		private Dictionary<Utente, List<MovimentoDiDenaro>> movimentiDiDenaro;

		public Utente(string email, string password, string nome, string cognome)
		{
			this._email = email;
			this._password = password;
			this._nome = nome;
			this._cognome = cognome;
		}

		public Utente(string email, string password, string nome, string cognome, string foto) 
			: this(email, password, nome, cognome)
		{
			this._foto = foto;
			Foto = foto;
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
			set { _foto = value; }
		}

		public List<Gruppo> Gruppi
		{
			get { return gruppi; }
			set { gruppi = value; }
		}

		public void aggiungiGruppo(Gruppo gruppo)
		{
			Gruppi.Add(gruppo);
		}
	}
}