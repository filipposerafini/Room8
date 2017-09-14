using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room8
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            GestoreUtenti dati = GestoreUtenti.Instance;
            IPersistenza<Gruppo> persistenzaGruppi = new PersistenzaGruppiXML("../../Resources/DB/inizializzazione.xml");
            dati.Carica(persistenzaGruppi);

			LoginForm loginForm = new LoginForm();
			new LoginFormPresenter(loginForm);
			Application.Run(loginForm);
		}
	}
}
