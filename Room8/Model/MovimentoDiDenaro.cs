using System;
namespace Room8
{
	public abstract class MovimentoDiDenaro
	{
		private readonly string _id;
		private readonly Utente _sorgente;
		private readonly Utente _destinazione;
		private readonly decimal _importo;

		private string GenerateId()
		{
			return Guid.NewGuid().ToString();
		}

		public MovimentoDiDenaro(Utente _sorgente, Utente _destinazione, decimal _importo)
		{
			this._id = GenerateId();
			this._sorgente = _sorgente;
			this._destinazione = _destinazione;
			this._importo = _importo;
		}

		public string Id
		{
			get { return _id; }
		}

		public Utente Sorgente
		{
			get { return _sorgente; }
		}

		public Utente Destinazione
		{
			get { return _destinazione; }
		}

		public decimal Importo
		{
			get { return _importo; }
		}
	}
}
