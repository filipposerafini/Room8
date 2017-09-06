using Room8.View;

namespace Room8
{
	class ProfiloFormPresenter
	{
		ProfiloForm _profiloForm;
		Utente _utente;

		public ProfiloFormPresenter(ProfiloForm profiloForm, Utente utente)
		{
			this._profiloForm = profiloForm;
			this._utente = utente;
		}
	}
}