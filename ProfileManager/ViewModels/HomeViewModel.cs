using System.Collections.Generic;
using ProfileManager.Models;

namespace ProfileManager.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Applicatie> Applicaties { get; set; }
    }
}