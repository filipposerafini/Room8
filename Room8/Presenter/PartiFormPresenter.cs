using Room8.View;

namespace Room8
{
	class PartiFormPresenter
	{
		string nomeMetodo;
		PartiForm partiForm;

		public PartiFormPresenter(PartiForm partiForm, string nomeMetodo)
		{
			this.partiForm = partiForm;
			this.nomeMetodo = nomeMetodo;
		}
	}
}