using System;

namespace ProfileManager.Models
{
    public class PersoonScrumTeam
    {
       public int PersoonId { get; set; }
       public Persoon Persoon { get; set; }
       public int ScrumTeamId { get; set; }
       public ScrumTeam ScrumTeam { get; set; }
    }
}