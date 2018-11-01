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
        private IScheduleRepository repository;

        public CalendarController(IScheduleRepository scheduleRepository)
        {
            this.repository = scheduleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ThisDay(DateTime date)
        {
            CalendarViewModel model = new CalendarViewModel
            {
                Schedules = repository.Schedules
                .Where(p => p.Date.Date == date.Date),
                SelectDate = date
            };
            return View(model);
        }
    }
}