using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendeeEauTest2.Models;
using VendeeEauTest2.Services;

namespace VendeeEauTest2.Controllers
{
    public class ConseilLocalController : Controller
    {
        private IRepository<ConseilLocal> _conseillocal;

        public ConseilLocalController(IRepository<ConseilLocal> conseillocal)
        {
            _conseillocal = conseillocal;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ConseilLocal()
        {
            return View(_conseillocal.GetAll());
        }
    }
}