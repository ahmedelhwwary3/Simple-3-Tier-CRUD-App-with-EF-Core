




using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities
{
    [Table("Doctors")]
    public class DoctorDomain
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorID { get; set; }
        [ForeignKey("Person")]
        public int PersonID { get; set; }
        [InverseProperty("Doctor")]
        public virtual PersonDomain Person { get; set; }
        [Required]
        [StringLength(50)]
        public string Specialization { get; set; }
    }


    [NotMapped]
    public class DoctorFullData
    {


        public int DoctorID { get; set; }
        public string Name {  get; set; }
 
        public string Specialization { get; set; }
    }
}