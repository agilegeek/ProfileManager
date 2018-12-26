using ProfileManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileManager.Repositories
{
    public class ApplicatieRepository : IApplicatieRepository
    {
        private readonly ProfileManagerContext _profileManagerContext;

        public ApplicatieRepository(ProfileManagerContext profileManagerContext)
        {
            _profileManagerContext = profileManagerContext;
        }

        public bool AddApplicatie(Applicatie applicatie)
        {
           return ( _profileManagerContext.Applicaties.Add(applicatie) != null);
        }

        public IEnumerable<Applicatie> GetAllApplicaties()
        {
            return _profileManagerContext.Applicaties;
        }

        public Applicatie GetApplicatieById(int applicatieId)
        {
            return _profileManagerContext.Applicaties.FirstOrDefault(a => a.ApplicatieId == applicatieId);
        }
    }
}
