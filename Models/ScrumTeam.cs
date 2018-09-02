using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class ScrumTeam
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public List<Persoon> Leden { get; set; }
        public List<Applicatie> Applicaties { get; set; }
    }
}