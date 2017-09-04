using System;
namespace Room8
{
	public class Movimento : MovimentoDiDenaro
	{
		private readonly Spesa _spesa;

		public Movimento(Utente sorgente, Utente destinazione, decimal importo, Spesa spesa)
			: base(sorgente, destinazione, importo)
		{
			this._spesa = spesa;
		}

		public Spesa Spesa
		{
			get { return _spesa; }
		}
	}
}
