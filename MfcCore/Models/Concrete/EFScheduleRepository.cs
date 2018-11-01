using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MfcCore.Models.Concrete
{
    public class EFScheduleRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Schedule> Schedules
        {
            get { return context.Schedules; }
        }
    }
}
