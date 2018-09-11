using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface IGildeRepository
    {
        IEnumerable<Gilde> GetAllGildes();
        Gilde GetGildeById(int gildeId);
    }
}