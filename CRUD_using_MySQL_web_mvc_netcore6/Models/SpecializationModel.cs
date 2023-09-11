using System.ComponentModel.DataAnnotations;

namespace CRUD_using_MySQL_web_mvc_netcore6.Models
{
    public class SpecializationModel
    {
        public SpecializationModel()
        {
            PhysicianModel = new HashSet<PhysicianModel>();
        }
        [Key]
        public int SpecializationId { get; set; }
        public string? Type { get; set; }
        public bool Status  { get; set; }

        public virtual ICollection<PhysicianModel> PhysicianModel { get; set; }

    }
}
