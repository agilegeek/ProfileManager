using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public Persoon Manager { get; set; }
        public List<Persoon> Leden { get; set; }

    }
}