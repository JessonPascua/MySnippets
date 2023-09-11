using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_using_MySQL_web_mvc_netcore6.Models;

namespace CRUD_using_MySQL_web_mvc_netcore6.Data
{
    public class HealthCareDbContext : DbContext
    {
        public HealthCareDbContext (DbContextOptions<HealthCareDbContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_using_MySQL_web_mvc_netcore6.Models.PatientModel> PatientModel { get; set; } = default!;
    }
}
