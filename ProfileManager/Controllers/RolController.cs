using Microsoft.AspNetCore.Mvc;
using ProfileManager.Repositories;
using ProfileManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileManager.Controllers
{
    public class RolController : Controller
    {
        private readonly IRolRepository _rolRepository;

        public RolController(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public IActionResult Index()
        {
            var rolViewModel = new ListRolViewModel
            {
                Title = "Lijst van Rollen",
                Rollen = _rolRepository.GetAllRollen().OrderBy(r => r.Naam).ToList()
            };

            return View(rolViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var newRol = new NewRolViewModel();

            return View(newRol);
        }

        [HttpPost]
        public bool Add(NewRolViewModel newRol)
        {
            return _rolRepository.AddRol(newRol.Rol);
        }

    }
}
