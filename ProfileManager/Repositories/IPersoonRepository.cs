using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface IPersoonRepository
    {
        IEnumerable<Persoon> GetAllPersonen();
        Persoon GetPersoonById(int persoonId);
    }
}