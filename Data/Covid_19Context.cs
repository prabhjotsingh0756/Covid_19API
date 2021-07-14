using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Covid_19.Models;

namespace Covid_19.Data
{
    public class Covid_19Context : DbContext
    {
        public Covid_19Context (DbContextOptions<Covid_19Context> options)
            : base(options)
        {
        }

        public DbSet<Covid_19.Models.Login> Login { get; set; }

        public DbSet<Covid_19.Models.Doctor> Doctor { get; set; }

        public DbSet<Covid_19.Models.Patient> Patient { get; set; }

        public DbSet<Covid_19.Models.testReport> testReport { get; set; }
    }
}
