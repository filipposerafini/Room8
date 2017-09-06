using System;
using System.Collections.Generic;

namespace Room8
{
    public interface IPersistenza
    {
        void Salva(GestoreUtenti dati);
        List<Utente> CaricaUtenti();
        List<Gruppo> CaricaGruppi();
    }
}

