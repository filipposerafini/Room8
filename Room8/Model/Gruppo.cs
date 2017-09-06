using System;
using System.Collections.Generic;
using System.Linq;

namespace Room8
{
	public class Gruppo
	{
		private static readonly string FOTODEFAULT = "/pathto/fotodefault.jpg";
		private string _id;
		private string _nome;
		private List<Utente> _membriGruppo;
		private SpeseGruppo _speseGruppo;
		private List<Prodotto> _daComprare;
		private DateTime _dataCreazione;
		private string _foto;

		public Gruppo(string nome)
		{
			if (String.IsNullOrEmpty(nome))
				throw new ArgumentException("nome is null or empty");

			this._id = Guid.NewGuid().ToString();
			this._nome = nome;
			this._membriGruppo = new List<Utente>();
			this._speseGruppo = new SpeseGruppo(this);
			this._daComprare = new List<Prodotto>();
			this._dataCreazione = DateTime.Now;
			this._foto = FOTODEFAULT;
		}

		public Gruppo(string nome, string foto)
			: this(nome)
		{
			if (String.IsNullOrEmpty(foto))
				throw new ArgumentException("foto is null or empty");

			this._foto = foto;
		}

		public string Id
		{
			get { return _id; }
		}

		public string Nome
		{
			get { return _nome; }
		}

		public IList<Utente> MembriGruppo
		{
			get { return _membriGruppo; }
		}

		public SpeseGruppo SpeseGruppo
		{
			get { return _speseGruppo; }
		}

		public IList<Prodotto> DaComprare
		{
			get { return _daComprare.AsReadOnly(); }
		}

		public DateTime DataCreazione
		{
			get { return _dataCreazione; }
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

		public void AggiungiProdotto(Prodotto prodotto)
		{
			if (prodotto == null)
				throw new ArgumentException("Prodotto null");

			// Versione Linq
			try
			{
				Prodotto p = DaComprare.Single(s => prodotto.Nome.Equals(s.Nome));
				p.Quantita += prodotto.Quantita;
			}
			catch (InvalidOperationException)
			{
				_daComprare.Add(prodotto);
			}
		}

		public void RimuoviProdotto(string nome)
		{
			if (nome == null)
				throw new ArgumentException("Nome prodotto null");

			try
			{
				Prodotto p = DaComprare.Single(s => nome.Equals(s.Nome));
				_daComprare.Remove(p);
			}
			catch (InvalidOperationException)
			{
				throw new ArgumentException("Prodotto non presente");
			}
		}

		public void AggiungiMembro(Utente utente)
		{
			if (utente == null)
				throw new ArgumentException("Utente null");

			if (_membriGruppo.Contains(utente))
				throw new ArgumentException("Utente già presente");

			_membriGruppo.Add(utente);
			// aggiorniamo anche la lista di gruppi di cui l'utente è membro
			utente.AggiungiGruppo(this);
		}

		public void RimuoviMembro(Utente utente)
		{
			if (utente == null)
				throw new ArgumentException("Utente null");

			if (!_membriGruppo.Contains(utente))
				throw new ArgumentException("Utente non presente");

			_membriGruppo.Remove(utente);
			// aggiorniamo anche la lista di gruppi di cui l'utente è membro
			utente.RimuoviGruppo(this);
		}
	}
}
