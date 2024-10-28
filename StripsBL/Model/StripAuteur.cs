using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsBL.Model
{
    public class StripAuteur
    {
        public int StripId { get; set; }           // Verwijzing naar een Strip
        public int AuteurId { get; set; }          // Verwijzing naar een Auteur

        // Navigatie-eigenschappen
        public Strip Strip { get; set; }
        public Auteur Auteur { get; set; }
    }

}
