using System;
namespace Room8
{
	public class Saldo : MovimentoDiDenaro
	{
		private readonly DateTime _data;

		public Saldo(Utente sorgente, Utente destinazione, decimal importo, DateTime data)
			: base(sorgente, destinazione, importo) 
		{
			this._data = data;
		}

		public DateTime Data
		{
			get { return _data; }
		}
	}
}
