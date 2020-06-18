using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HealthLink.Controllers
{
    public class HospitalsController : Controller
    {
        public IActionResult Index()

        {
            return View();
        }

        public IActionResult Donors()

        {
            return View();
        }

        public IActionResult Recievers()

        {
            return View();
        }

        public IActionResult PostBlog()

        {
            return View();
        }

        public IActionResult Info()

        {
            return View();
        }




    }
}