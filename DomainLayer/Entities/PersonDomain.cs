

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DomainLayer.Entities
{
    [Table("People")]
    public class PersonDomain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }
        [AllowNull]
        public DateTime DateOfBirth { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
   
        [InverseProperty("Person")]
        public virtual DoctorDomain Doctor { get; set; }


    }
}
