using Microsoft.EntityFrameworkCore;
using ProjectManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ProjectManagementApp.db");
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectActivity> ProjectActivities { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Vacation> Vacations { get; set; }

    }
}
