using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Model
{
    public class Uitgeverij
    {
        public int Id { get; set; }                // Unieke ID voor de uitgeverij
        public string Naam { get; set; }           // Naam van de uitgeverij

        // Navigatie-eigenschap
        public List<Strip> Strips { get; set; }    // Alle strips die door deze uitgeverij zijn uitgegeven
    }

}
