using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Model
{
    public class Reeks
    {
        public int Id { get; set; }                // Unieke ID voor de reeks
        public string Naam { get; set; }           // Naam van de reeks

        // Navigatie-eigenschap
        public List<Strip> Strips { get; set; }    // Alle strips die bij de reeks horen
    }
}
