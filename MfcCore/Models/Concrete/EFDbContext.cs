using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MfcCore.Models.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
    }
}
