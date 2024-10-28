using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Model
{
    public class Auteur
    {
        public int Id { get; set; }                // Unieke ID voor de auteur
        public string Naam { get; set; }           // Naam van de auteur

        // Navigatie-eigenschap
        public List<StripAuteur> StripAuteurs { get; set; } // Alle strips waar de auteur aan heeft gewerkt
    }
}
