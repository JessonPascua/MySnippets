using CRUD_using_MySQL_web_mvc_netcore6.Data;
using CRUD_using_MySQL_web_mvc_netcore6.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_using_MySQL_web_mvc_netcore6
{
    public class SeedData
    {
        public async static Task MySeedData(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<HealthCareDbContext>();
                await SeedSpecialization(dbContext);
                await SeedDoctors(dbContext);
            }
        }

        private static async Task SeedSpecialization(HealthCareDbContext dbContext)
        {
            var specialties = new[] { "Internal medicine", "Pediatrics", "Gynaecology", "Orthopedics",
                                   "Psychiatry", "Pathology", "Urology", "Emergency medicine" , "General Surgery"};
            foreach (var skill in specialties)
            {
                if (!await dbContext.Specializations.AnyAsync(x => x.Type == skill))
                {
                    var specializations = new Specializations
                    {
                        Type = skill,
                        Status = true
                    };

                    dbContext.Add(specializations);
                }
            }

            await dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        private static async Task SeedDoctors(HealthCareDbContext dbContext)
        {
            var doctors = new[] { "monkey.luffy", "john.malerich", "maria.loeffler", "ricci.joe", "blackleg.sanji", "kuroru.zoro", "nami.shawn" };
            foreach (var dr in doctors)
            {
                string[] sname = dr.Split('.');
                if (!await dbContext.Physicians.AnyAsync(x => x.DoctorFirstName == sname[0] || x.DoctorFirstName == sname[1]))
                {
                    var physicians = new Physicians
                    {
                        DoctorFirstName = sname[0],
                        DoctorLastName = sname[1],
                        SpecializationId = new Random().Next(1, 9)
                    };

                    dbContext.Add(physicians);
                }
            }

            await dbContext.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}