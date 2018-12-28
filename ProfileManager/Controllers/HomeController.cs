using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Repositories;
using ProfileManager.ViewModels;

namespace ProfileManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IApplicatieRepository _applicatieRepository;

        public HomeController(IApplicatieRepository applicatieRepository)
        {
            _applicatieRepository = applicatieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Title = "Lijst van Applicaties",
                Applicaties = _applicatieRepository.GetAllApplicaties().OrderBy(a => a.Naam).ToList()
            };

            return View(homeViewModel);
        }
    }
}