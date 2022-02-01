using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class Phone 
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

        [Column("phoneNumber")]
        [Required]
        [StringLength(10)]
        public string phoneNumber { get; set; }

    }

