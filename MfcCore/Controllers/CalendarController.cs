using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MfcCore.Models.Entities;
using MfcCore.Models.Concrete;

namespace MfcCore.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ThisDay()
        {
            CalendarViewModel model = new CalendarViewModel();
            return View();
        }
    }
}