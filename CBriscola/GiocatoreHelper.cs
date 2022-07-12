using System;
using System.Collections.Generic;
using System.Text;

namespace CBriscola
{
    interface GiocatoreHelper
    {
        int Gioca(Carta[] v, int i);
        int Gioca(Carta[] v, Carta c, int i);
        int GetPunteggio(Carta c, Carta c1);
        void Paint(String nome, Carta[] mano, int iCartaGiocata);
    }
}
