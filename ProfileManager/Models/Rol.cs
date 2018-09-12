using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileManager.Models
{
    public class Rol
    {
        public int RolId { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public ICollection<PersoonRol> PersoonRollen { get; set; }
    }
}
