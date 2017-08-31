using System;
using System.Collections.Generic;
using System.Linq;

namespace Room8
{
	public class Gruppo
	{
		private static readonly string FOTODEFAULT = "/pathto/fotodefault.jpg";
		private readonly string _id;
		private readonly string _nome;
		private readonly MembriGruppo _membriGruppo;
		private readonly SpeseGruppo _speseGruppo;
		private readonly List<Prodotto> _daComprare;
		private readonly DateTime _dataCreazione;
		private string _foto;

		private string GenerateId() 
		{
			return Guid.NewGuid().ToString();
		}

		public Gruppo(string nome)
		{
			if (String.IsNullOrEmpty(nome))
				throw new ArgumentException("nome is null or empty");

			this._id = GenerateId();
			this._nome = nome;
			this._membriGruppo = new MembriGruppo(this);
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

		public MembriGruppo MembriGruppo
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
	}
}
