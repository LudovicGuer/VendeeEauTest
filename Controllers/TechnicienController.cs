using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendeeEauTest2.Models;
using VendeeEauTest2.Services;

namespace VendeeEauTest2.Controllers
{
    public class TechnicienController : Controller
    {
        private IRepository<Technicien> _technicien;

        public TechnicienController(IRepository<Technicien> technicien)
        {
            _technicien = technicien;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Technicien()
        {
            return View(_technicien.GetAll());
        }
        
    }
}