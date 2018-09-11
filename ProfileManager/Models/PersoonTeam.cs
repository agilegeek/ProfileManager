using System;

namespace ProfileManager.Models
{
    public class PersoonTeam
    {
       public int PersoonId { get; set; }
       public Persoon Persoon { get; set; }
       public int TeamId { get; set; }
       public Team Team { get; set; }
    }
}