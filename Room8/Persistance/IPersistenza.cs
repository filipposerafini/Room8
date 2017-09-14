using System;
using System.Collections.Generic;

namespace Room8
{
    public interface IPersistenza<T>
    {
        IEnumerable<T> CaricaElementi();
        void SalvaElementi(IEnumerable<T> elementi);
    }
}

