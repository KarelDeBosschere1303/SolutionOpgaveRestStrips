using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Model
{
    public class Strip
    {
        public int Id { get; set; }                // Unieke ID voor de strip
        public string Titel { get; set; }          // Titel van de strip
        public int VolgnummerInReeks { get; set; } // Volgnummer in de reeks (zoals 1, 2, 3 etc.)
        public int ReeksId { get; set; }           // Verwijzing naar de Reeks
        public int UitgeverijId { get; set; }      // Verwijzing naar de Uitgeverij

        // Navigatie-eigenschappen
        public Reeks Reeks { get; set; }
        public Uitgeverij Uitgeverij { get; set; }
        public List<StripAuteur> StripAuteurs { get; set; } // Lijst van auteurs (via tussenliggende tabel)
    }
}
