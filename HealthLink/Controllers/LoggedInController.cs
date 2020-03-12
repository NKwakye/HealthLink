using System.Linq;
using HealthLink.Models;
using HealthLink.Repository;
using HealthLink.Models.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HealthLink.Controllers
{
    public class LoggedInController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IProfileRepository _profileRepository;

        public LoggedInController(UserManager<AppUser> userManager, IProfileRepository profileRepository)
        {
            _userManager = userManager;
            _profileRepository = profileRepository;
        }

        public IActionResult Index()
        {
            

            return View();
        }

    }
}
