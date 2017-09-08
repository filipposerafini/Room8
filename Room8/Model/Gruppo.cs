using System;
using System.Collections.Generic;
using System.Linq;

namespace Room8
{
	public class Gruppo
	{
		private static string FOTODEFAULT = "../../Resources/Images/defaultgroup.jpg";
		private readonly string _id;
		private string _nome;
		private readonly List<Utente> _membriGruppo;
		private readonly SpeseGruppo _speseGruppo;
		private readonly List<Prodotto> _daComprare;
		private string _foto;

		public Gruppo(string nome)
		{
			if (String.IsNullOrEmpty(nome))
				throw new ArgumentException("Inserisci un nome", "nome");

			this._id = Guid.NewGuid().ToString();
			Nome = nome;
			this._membriGruppo = new List<Utente>();
			this._speseGruppo = new SpeseGruppo(this);
			this._daComprare = new List<Prodotto>();
			this._foto = FOTODEFAULT;
		}

		public string Id
		{
			get { return _id; }
		}

		public string Nome
		{
			get { return _nome; }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Inserisci un nome", "nome");
				_nome = value;
			}
		}

		public IList<Utente> MembriGruppo
		{
			get { return _membriGruppo.AsReadOnly(); }
		}

		public SpeseGruppo SpeseGruppo
		{
			get { return _speseGruppo; }
		}

		public IList<Prodotto> DaComprare
		{
			get { return _daComprare.AsReadOnly(); }
		}

		public string Foto
		{
			get { return _foto; }

			set
			{
				if (string.IsNullOrEmpty(value))
					_foto = FOTODEFAULT;
				if (value.EndsWith(".jpg") || value.EndsWith(".png"))
					throw new ArgumentException("Inserisci una foto valida", "foto");

				_foto = value;
			}
		}

		public void AggiungiProdotto(Prodotto prodotto)
		{
			if (prodotto == null)
				throw new ArgumentNullException("prodotto");

			Prodotto p = _daComprare.Find(s => prodotto.Nome.Equals(s.Nome));
			if (p == null)
				_daComprare.Add(prodotto);
			else
				p.Quantita += prodotto.Quantita;
		}

		public void RimuoviProdotto(string nome)
		{
			if (nome == null)
				throw new ArgumentNullException("nome");

			Prodotto p = _daComprare.Find(s => nome.Equals(s.Nome));
			if (p == null)
				throw new ArgumentException("Prodotto non presente");
			_daComprare.Remove(p);
		}

		public void AggiungiMembro(Utente utente)
		{
			if (utente == null)
				throw new ArgumentNullException("utente");

			if (MembriGruppo.Contains(utente))
				throw new ArgumentException("Utente già presente", "membro");

			_membriGruppo.Add(utente);
			// aggiorniamo anche la lista di gruppi di cui l'utente è membro
			utente.AggiungiGruppo(this);
		}

		public void RimuoviMembro(Utente utente)
		{
			if (utente == null)
				throw new ArgumentNullException("utente");

			if (!MembriGruppo.Contains(utente))
				throw new ArgumentException("Utente non presente");

			_membriGruppo.Remove(utente);
			// aggiorniamo anche la lista di gruppi di cui l'utente è membro
			utente.RimuoviGruppo(this);
		}
	}
}
