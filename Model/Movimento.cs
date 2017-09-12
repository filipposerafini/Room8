using System;
namespace Room8
{
	public class Movimento : MovimentoDiDenaro
	{
		private readonly Spesa _spesa;

		public Movimento(Utente sorgente, Utente destinazione, decimal importo, Spesa spesa)
			: base(sorgente, destinazione, importo)
		{
			_spesa = spesa;
		}

		public Spesa Spesa
		{
			get { return _spesa; }
		}

		public override void AggiungiMovimentoDiDenaro()
		{
			if (Sorgente.Equals(Destinazione))
				throw new ArgumentException("Sorgente e destinazione devono essere diversi", "sorgente/destinazione");
			if (!Spesa.SpeseGruppo.Gruppo.MembriGruppo.Contains(Sorgente)
			    || !Spesa.SpeseGruppo.Gruppo.MembriGruppo.Contains(Destinazione))
				throw new ArgumentException("Sorgente e destinazione devono far parte dello stesso gruppo", "sorgente/destinazione");

			Sorgente.MovimentiDiDenaro.Add(this);
			Destinazione.MovimentiDiDenaro.Add(this);
		}
	}
}
