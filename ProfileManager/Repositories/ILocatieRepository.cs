using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface ILocatieRepository
    {
        IEnumerable<Locatie> GetAllLocaties();
        Locatie GetLocatieById(int locatieId);
    }
}