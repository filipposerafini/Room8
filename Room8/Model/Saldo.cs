using System;
namespace Room8
{
	public class Saldo : MovimentoDiDenaro
	{
		private DateTime _data;

		public Saldo(Utente sorgente, Utente destinazione, decimal importo, DateTime data)
			: base(sorgente, destinazione, importo)
		{
			Data = data;
		}

		public DateTime Data
		{
			get { return _data; }
            set
            {
                if (value.Equals(DateTime.MinValue))
                    throw new ArgumentNullException("data");
                if (value.CompareTo(DateTime.Now) > 0)
                    throw new ArgumentException("La data non può essere successiva a quella di oggi", "data");
                _data = value;
            }
		}

		public override void AggiungiMovimentoDiDenaro()
		{
			if (Sorgente.Equals(Destinazione))
				throw new ArgumentException("Sorgente e destinazione devono essere diversi", "sorgente/destinazione");
			if (!Sorgente.Amici().Contains(Destinazione))
				throw new ArgumentException("Sorgente e destinazione devono essere amici", "sorgente/destinazione");
			if (Sorgente.CalcolaSituazione(Destinazione) == 0)
				throw new ArgumentException("Deve esistere un debito/credito tra sorgente e destinazione", "sorgente/destinazione");

			Sorgente.MovimentiDiDenaro.Add(this);
			Destinazione.MovimentiDiDenaro.Add(this);
		}
	}
}
