using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACC_V401_ZON.Enti_Piazzale
{
    class SegnaleBasso
    {
        string id_segnalebasso; // es. "SB1"
        bool aperto; // true se è possibile transitare
        bool chiuso; // true se non è possibile transitare
        bool controllo; // true se ha il controllo ? i segnali bassi hanno il controllo?
        bool esis; // true se esis in atto; false se esis non in atto
        // ricordarsi che va anche collegato ai segnali alti (es segnale verde = segnale alto verde + segnale basso aperto)
    }
}
