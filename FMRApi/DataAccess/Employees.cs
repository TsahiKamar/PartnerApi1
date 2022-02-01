using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LEUMITApi.DataAccess
{

    [Table("Employees")]
    public class Employees
    {
        [Column("id")]
        [Required]
        [StringLength(10)]
        public string id { get; set; }

        [Column("fullName")]
        [Required]
        [StringLength(100)]
        public string fullName { get; set; }


        [Column("phone")]
        [Required]
        [StringLength(10)]
        public string phone { get; set; }

        [Column("email")]
        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Column("salary")]
        [Required]
        public int salary { get; set; }

    }

}
