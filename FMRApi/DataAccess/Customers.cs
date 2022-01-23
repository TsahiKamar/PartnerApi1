using FMRApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMRApi.DataAccess
{

    [Table("Customers")]
    public class Customers : Base
    {
        [Column("customerId")]
        [Required]
        [StringLength(10)]
        public string customerId { get; set; }

        [Column("fullName")]
        [Required]
        [StringLength(100)]
        public string fullName { get; set; }

        public List<Address> addresses { get; set; } //virtual
        public List<Product> products { get; set; }
        public List<Phone> phones { get; set; }


    }

}
