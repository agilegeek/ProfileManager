using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Naam { get; set; }
        public Persoon Manager { get; set; }
        public ICollection<PersoonTeam> PersoonTeams { get; set; }

    }
}