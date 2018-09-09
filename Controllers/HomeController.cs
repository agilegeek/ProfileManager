using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProfileManager.Repositories;

namespace ProfileManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicatieRepository _applicatieRepository;

        public HomeController(IApplicatieRepository applicatieRepository)
        {
            _applicatieRepository = applicatieRepository;
        }

        public IActionResult Index()
        {
            var applicaties = _applicatieRepository.GetAllApplicaties().OrderBy(a => a.Naam);

            return View();
        }
    }
}