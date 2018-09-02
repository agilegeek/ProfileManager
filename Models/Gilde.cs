using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class Gilde
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public Persoon Lead { get; set; }
        public List<Persoon> Leden { get; set; }
    }
}