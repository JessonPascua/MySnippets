using System.ComponentModel.DataAnnotations;

namespace CRUD_using_MySQL_web_mvc_netcore6.Models
{
    public class PatientModel
    {
        [Key]
        public int Id { get; set; }
        public string? FristName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public int? AssignedDoctorId { get; set; }
        public DateTime Schedule { get; set; }

        public virtual PhysicianModel? Physician { get; set; }
    }
}
