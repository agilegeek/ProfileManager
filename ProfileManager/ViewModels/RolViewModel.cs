using ProfileManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileManager.ViewModels
{
    public class ListRolViewModel
    {
        public string Title { get; set; }
        public List<Rol> Rollen { get; set; }
    }
}
