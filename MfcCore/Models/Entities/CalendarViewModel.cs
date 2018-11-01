using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MfcCore.Models.Concrete;

namespace MfcCore.Models.Entities
{
    public class CalendarViewModel
    {
        public IEnumerable<Schedule> Schedules { get; set; }
        public DateTime Date { get; set; }
    }
}
