using System.ComponentModel.DataAnnotations;

namespace CRUD_using_MySQL_web_mvc_netcore6.Models
{
    public class PhysicianModel
    {
        public PhysicianModel()
        {
             PatientModel = new HashSet<PatientModel>();
        }

        [Key]
        public int DoctorId { get; set; }
        public string? DoctorFirstName { get; set; }
        public string? DoctorLastName { get; set; }
        public int? SpecializationId { get; set; }
        public virtual SpecializationModel? Specialization { get; set; }
        public virtual ICollection<PatientModel> PatientModel { get; set; }
    }
}
