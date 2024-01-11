using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACC_V401_ZON.Enti_Piazzale
{
    class Deviatoio
    {
        string id_deviatoio;    // es. "D1"
        string tipo_deviatoio;  // es. P80/L90/CTS
        bool istrada_destra;  
        bool istrada_sinistra;  // rendere dipendenti i due bool
        bool controllo_deviatoio; // true se ha il controllo
        bool elettromagnete; // true se ha l'elettromagnete
        bool elettromagnete_basso;
        bool fermascambiato; // true se fermascambiato
        bool intallonabile_permanentemente; // true se è intallonabile permanentemente
        bool intallonabile_a_comando; // true se è intallonabile a comando
        // mettere funzione per rilevare i tipi di perdita di controllo
        bool esis; // true se esis in atto; false se esis non in atto
        bool segnale_blu; // true se ha segnale blu
        bool segnale_blu_acceso; // true se ha segnale blu acceso
        bool dcf_presente; // true se è presente il dcf - ? ammettiamo l'esis per il SID? - dcf_presente non può esserci se è un deviatoio SO
        // capire come far associare il deviatoio alle zone da escludere
    }
}
