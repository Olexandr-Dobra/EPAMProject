using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Models
{
    public class FirstWebAppContext : DbContext
    {
        public FirstWebAppContext (DbContextOptions<FirstWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<FirstWebApp.Models.Student> Student { get; set; }
    }
}
