using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACC_V401_ZON.Enti_Piazzale
{
    class Segnale
    {
        string id_segnale; // es. "S1"
        string tipo_segnale; // es. "Protezione/Partenza/Avviso"
        // gestire la quantità di luci e i vela quadra con freccia + i segnali di avvio/avanzamento
        bool esis; // true se esis in atto; false se esis non in atto
        // aggiungere gli indicatori luminesi es CPX
    }
}
