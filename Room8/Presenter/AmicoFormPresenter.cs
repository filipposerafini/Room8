using Room8.View;

namespace Room8
{
	class AmicoFormPresenter
	{
		AmicoForm _amicoForm;
		Utente _utente;

		public AmicoFormPresenter(AmicoForm amicoForm, Utente utente)
		{
			this._amicoForm = amicoForm;
			this._utente = utente;
		}
	}
}