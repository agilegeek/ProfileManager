using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class ScrumTeam
    {
        public int ScrumTeamId { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public Persoon Scrummaster { get; set; }
        public Persoon Productowner { get; set; }
        public Locatie Locatie { get; set; }
        public ICollection<PersoonScrumTeam> PersoonScrumTeams { get; set; }
        public ICollection<Applicatie> Applicaties { get; set; }
    }
}