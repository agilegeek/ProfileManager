using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public interface IRolRepository
    {
        IEnumerable<Rol> GetAllRollen();
        Rol GetRolById(int rolId);
        bool AddRol(Rol rol);
    }
}
