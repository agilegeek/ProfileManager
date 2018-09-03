using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class Gilde
    {
        public int GildeId { get; set; }
        public string Naam { get; set; }
        public Persoon Lead { get; set; }
        public IEnumerable<PersoonGilde> PersoonGildes { get; set; }
    }
}