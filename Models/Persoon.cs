using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class Persoon
    {
        public int PersoonId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Functie { get; set; }
        public ICollection<PersoonTeam> PersoonTeams { get; set; }
        public ICollection<PersoonScrumTeam> PersoonScrumTeams { get; set; }
        public ICollection<PersoonGilde> PersoonGildes { get; set; }
        public ICollection<Competentie> Competenties { get; set; }
    }
}