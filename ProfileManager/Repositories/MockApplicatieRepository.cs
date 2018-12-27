using System;
using System.Collections.Generic;
using System.Linq;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public class MockApplicatieRepository : IApplicatieRepository
    {
        private List<Applicatie> _applicaties;
        public MockApplicatieRepository()
        {
            if (_applicaties == null)
            {
                InitializeApplicaties();
            }
        }

        private void InitializeApplicaties()
        {
            _applicaties = new List<Applicatie>();
            _applicaties.Add(new Applicatie { ApplicatieId = 1, Naam = "MijnZV", Versie = "1.0.0.164", Technologie = "ASP.NET" } );
            _applicaties.Add(new Applicatie { ApplicatieId = 3, Naam = "WACViewer", Versie = "1.0.0.12", Technologie = "ASP.NET" } );
            _applicaties.Add(new Applicatie { ApplicatieId = 4, Naam = "WACService", Versie = "1.0.0.14", Technologie = "WCF"} );
            _applicaties.Add(new Applicatie { ApplicatieId = 5, Naam = "WACSSA", Versie = "1.0.0.81", Technologie = "ASP.NET" } );
            _applicaties.Add(new Applicatie { ApplicatieId = 6, Naam = "Nota APP", Versie = "1.0.0.1", Technologie = "Outsystems" } );
        }

        public IEnumerable<Applicatie> GetAllApplicaties()
        {
            return _applicaties;
        }

        public Applicatie GetApplicatieById(int applicatieId)
        {
                return _applicaties.FirstOrDefault(a => a.ApplicatieId == applicatieId);
        }

        public bool AddApplicatie(Applicatie applicatie)
        {
            var count = _applicaties.Count;
            _applicaties.Add(applicatie);

            return (_applicaties.Count > count);
        }
    }
}