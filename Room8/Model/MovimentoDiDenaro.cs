using System;
namespace Room8
{
	public abstract class MovimentoDiDenaro
	{
		private readonly string _id;
		private Utente _sorgente;
		private Utente _destinazione;
		private decimal _importo;

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

        public MovimentoDiDenaro()
        {
            this._id = GenerateId();
        }

		public string Id
		{
			get { return _id; }
		}

		public Utente Sorgente
		{
			get { return _sorgente; }
            set 
            {
                if (value == null)
                    throw new ArgumentException("sorgente");
                _sorgente = value;
            }
		}

		public Utente Destinazione
		{
			get { return _destinazione; }
            set 
            {
                if (value == null)
                    throw new ArgumentException("destinazione");
                _destinazione = value;
            }
		}

		public decimal Importo
		{
			get { return _importo; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("L'importo deve essere maggiore di 0", "importo");
                _importo = value;
            }
		}


		public void AggiungiMovimentoDiDenaro()
		{
            if (this is Saldo && this.Sorgente.Equals(this.Destinazione))
                    throw new DataMisalignedException("Sorgente e destinazione devono essere diversi");

			Sorgente.MovimentiDiDenaro.Add(this);
			Destinazione.MovimentiDiDenaro.Add(this);
		}

		public void RimuoviMovimentoDiDenaro()
		{
			if (!Sorgente.MovimentiDiDenaro.Remove(this))
				throw new ArgumentException("movimento non presente");
			if (!Destinazione.MovimentiDiDenaro.Remove(this))
				throw new ArgumentException("movimento non presente");
		}

		public void ModificaMovimentoDiDenaro(MovimentoDiDenaro nuovoMovimento)
		{
			if (nuovoMovimento == null)
				throw new ArgumentException("saldo null");

			this.RimuoviMovimentoDiDenaro();
			nuovoMovimento.AggiungiMovimentoDiDenaro();
		}
	}
}
