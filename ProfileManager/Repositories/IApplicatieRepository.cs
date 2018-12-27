using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface IApplicatieRepository
    {
        IEnumerable<Applicatie> GetAllApplicaties();
        Applicatie GetApplicatieById(int applicatieId);
        bool AddApplicatie(Applicatie applicatie);
    }
}