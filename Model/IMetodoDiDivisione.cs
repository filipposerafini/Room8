using System;
using System.Collections.Generic;

namespace Room8
{
	public interface IMetodoDiDivisione
	{
		Dictionary<Utente, decimal> DividiSpesa(decimal totale, Parti parti);

		void ControllaParti(Parti parti, decimal totale);
	}
}
