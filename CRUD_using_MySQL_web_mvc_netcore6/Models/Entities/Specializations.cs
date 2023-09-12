using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_using_MySQL_web_mvc_netcore6.Models
{
    public class Specializations
    {
        public Specializations()
        {
            Physicians = new HashSet<Physicians>();
        }

        [Key]
        [PersonalData]
        [Column(TypeName = "INT")]
        public int SpecializationId { get; set; }

        [PersonalData]
        [Column(TypeName = "VARCHAR(100)")]
        public string? Type { get; set; }

        [PersonalData]
        [Column(TypeName = "TINYINT")]
        public bool Status  { get; set; }

        public virtual ICollection<Physicians> Physicians { get; set; }
    }
}
