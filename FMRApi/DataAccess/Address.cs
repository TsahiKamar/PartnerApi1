using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMRApi.Models
{
    public class Address //: Base
    {

        [Column("customerId")]
        [Key]
        [Required]
        [StringLength(10)]
        public string customerId { get; set; }

        [Column("type")]
        [Required]
        [StringLength(10)]
        public string type { get; set; }

        [Column("city")]
        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [Column("street")]
        [StringLength(50)]
        public string street { get; set; }

        
        [Column("houseNum")]
        public int houseNum { get; set; }
        
        [Column("pob")]
        public int pob { get; set; }
        
        [Column("zip")]
        public int zip { get; set; }

    }

}
