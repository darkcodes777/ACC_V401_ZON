using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACC_V401_ZON.Enti_Piazzale
{
    class PassaggioaLivello
    {
        string id_passaggioalivello; // es. "PL1"
        bool stato_rovescio; // true se rovescio (APERTO)
        bool stato_normale; // true se normale (CHIUSO)
        bool controllo;
        bool allarme_a;
        bool allarme_b;
        bool allarme_c;
        bool esis; // true se esis in atto; false se esis non in atto
        // vanno aggiunte le luci stradali e i controlli di cassa, oltre alla possibilità di gestire i PL dotati di segnali propri
    }
}
