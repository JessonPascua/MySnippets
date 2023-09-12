using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_using_MySQL_web_mvc_netcore6.Models.Entities;
using CRUD_using_MySQL_web_mvc_netcore6.Models;

namespace CRUD_using_MySQL_web_mvc_netcore6.Data
{
    public class HealthCareDbContext : DbContext
    {
        public HealthCareDbContext (DbContextOptions<HealthCareDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patients> Patients { get; set; } = default!;
        public DbSet<Physicians> Physicians { get; set; } = default!;
        public DbSet<Specializations> Specializations { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
