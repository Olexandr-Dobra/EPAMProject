﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebApp.Models;
using FirstWebApp.Models.ViewModels;

namespace FirstWebApp.Models
{
    public class FirstWebAppContext : DbContext
    {
        public FirstWebAppContext (DbContextOptions<FirstWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<FirstWebApp.Models.Student> Student { get; set; }

        public DbSet<FirstWebApp.Models.Teacher> Teacher { get; set; }

        public DbSet<FirstWebApp.Models.Subjects> Subjects { get; set; }

        public DbSet<FirstWebApp.Models.Group> Group { get; set; }

        public DbSet<FirstWebApp.Models.User> Users { get; set; }

        public DbSet<FirstWebApp.Models.MarkOfTeacher> MarkOfTeacher { get; set; }
    }
}
