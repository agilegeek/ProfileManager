using System;
using System.Collections.Generic;

namespace ProfileManager.Models
{
    public class Persoon
    {
        public int ID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Functie { get; set; }
        public List<Team> Teams { get; set; }
        public List<ScrumTeam> ScrumTeams { get; set; }
        public List<Gilde> Gildes { get; set; }
        public List<Competentie> Competenties { get; set; }
    }
}