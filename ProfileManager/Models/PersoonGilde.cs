using System;

namespace ProfileManager.Models
{
    public class PersoonGilde
    {
       public int PersoonId { get; set; }
       public Persoon Persoon { get; set; }
       public int GildeId { get; set; }
       public Gilde Gilde { get; set; }
    }
}