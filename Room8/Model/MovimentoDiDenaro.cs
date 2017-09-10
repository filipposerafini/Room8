using System;
namespace Room8
{
	public abstract class MovimentoDiDenaro
	{
		private readonly string _id;
		private Utente _sorgente;
		private Utente _destinazione;
		private decimal _importo;

		protected MovimentoDiDenaro(Utente sorgente, Utente destinazione, decimal importo)
		{
            _id = Guid.NewGuid().ToString();
			Sorgente = sorgente;
			Destinazione = destinazione;
			Importo = importo;
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
                    throw new ArgumentNullException("sorgente");
				_sorgente = value;
            }
		}

		public Utente Destinazione
		{
			get { return _destinazione; }
            set 
            {
                if (value == null)
                    throw new ArgumentNullException("destinazione");
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

		public abstract void AggiungiMovimentoDiDenaro();

		public void RimuoviMovimentoDiDenaro()
		{
			if (!Sorgente.MovimentiDiDenaro.Remove(this))
				throw new ArgumentException("movimento non presente");
			if (!Destinazione.MovimentiDiDenaro.Remove(this))
				throw new ArgumentException("movimento non presente");
		}
	}
}
