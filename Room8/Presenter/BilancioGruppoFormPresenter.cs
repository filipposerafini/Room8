using Room8.View;

namespace Room8
{
	class BilancioGruppoFormPresenter
	{
		BilancioGruppoForm bilancioGruppoForm;
		Utente utente;

		public BilancioGruppoFormPresenter(BilancioGruppoForm bilancioGruppoForm, Utente utente)
		{
			this.bilancioGruppoForm = bilancioGruppoForm;
			this.utente = utente;
		}
	}
}