using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DssDemoApiApp.Data
{
    public class DssDemoApiAppContext : DbContext
    {
        public DssDemoApiAppContext (DbContextOptions<DssDemoApiAppContext> options)
            : base(options)
        {
        }

        public DbSet<DssDemoApiApp.Data.Employee> Employee { get; set; }
    }
}
