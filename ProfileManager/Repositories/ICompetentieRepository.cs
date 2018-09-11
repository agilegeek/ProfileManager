using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface ICompetentieRepository
    {
        IEnumerable<Competentie> GetAllCompetenties();
        Competentie GetCompetentieById(int competentieId);
    }
}