using System;
using System.Collections.Generic;

namespace Room8
{
	public interface IMetodoDiDivisione
	{
		Dictionary<Utente, decimal> DividiSpesa(decimal totale, Dictionary<Utente, int> parti);
	}
}
