using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface IApplicatieRepository
    {
        IList<Applicatie> GetAllApplicaties();
        Applicatie GetApplicatieById(int applicatieId);
    }
}