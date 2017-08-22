using System;
namespace Room8
{
	public class Prodotto
	{
		private readonly string _nome;
		private int _quantita;

		public Prodotto(string nome, int quantita)
		{
			this._nome = nome;
			this._quantita = quantita;
		}

		public string Nome
		{
			get { return _nome; }
		}

		public int Quantita
		{
			get { return _quantita; }

			set
			{
				if (value <= 0)
					throw new ArgumentException("Quantita negativa");

				_quantita = value;
			}
		}
	}
}
