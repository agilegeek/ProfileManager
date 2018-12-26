using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProfileManager.Models;

namespace ProfileManager.Repositories
{
    public class RolRepository : IRolRepository
    {
        private readonly ProfileManagerContext _profileManagerContext;

        public RolRepository(ProfileManagerContext profileManagerContext)
        {
            _profileManagerContext = profileManagerContext;
        }

        public bool AddRol(Rol rol)
        {
            return (_profileManagerContext.Rollen.Add(rol) != null);
        }

        public IEnumerable<Rol> GetAllRollen()
        {
            return _profileManagerContext.Rollen;
        }

        public Rol GetRolById(int rolId)
        {
            return _profileManagerContext.Rollen.FirstOrDefault(r => r.RolId == rolId);
        }
    }
}
