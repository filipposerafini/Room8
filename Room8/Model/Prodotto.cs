using System;
namespace Room8
{
	public class Prodotto
	{
		private readonly string _nome;
		private int _quantita;

		public Prodotto(string nome, int quantita)
		{
			if (string.IsNullOrEmpty(nome))
				throw new ArgumentException("Inserisci un nome", "nome");
			_nome = nome;
			Quantita = quantita;
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
					throw new ArgumentException("Inserisci una quantità positiva", "quantita");

				_quantita = value;
			}
		}
	}
}
