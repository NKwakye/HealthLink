using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthLink.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthLink.Controllers
{
    public class HospitalsController : Controller
    {
       

         private readonly ApplicationDBContext _db;

        public HospitalsController(ApplicationDBContext db)
        {
            _db = db;

            
        }

        public  IActionResult Index()

        {
            return View();
        }

        public async Task <IActionResult> Donors()

        {
            //var allDonors = await _db.Donors.ToListAsync();
            return View(await _db.Donors.ToListAsync());
        }

        public async Task<IActionResult> Recievers()

        {
            return View(await _db.Recievers.ToListAsync());
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