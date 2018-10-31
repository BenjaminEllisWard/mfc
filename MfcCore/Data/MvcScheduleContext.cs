using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MfcCore.Models
{
    public class MvcScheduleContext : DbContext
    {
        public MvcScheduleContext (DbContextOptions<MvcScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<MfcCore.Models.Schedule> Schedule { get; set; }
    }
}
