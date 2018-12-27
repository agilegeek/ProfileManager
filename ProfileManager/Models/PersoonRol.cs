using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileManager.Models
{
    public class PersoonRol
    {
        public int PersoonId { get; set; }
        public Persoon Persoon { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
