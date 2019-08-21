using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendeeEauTest2.Models;
using VendeeEauTest2.Services;

namespace VendeeEauTest2.Controllers
{
    public class EpciController : Controller
    {
        private IRepository<Epci> _epci;

        public EpciController(IRepository<Epci> epci)
        {
            _epci = epci;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Epci()
        {
            return View(_epci.GetAll());
        }

    }
}