using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public class Product
    {
        [Column("customerId")]
        [Key]
        [Required]
        [StringLength(10)]
        public string customerId { get; set; }


        [Column("productId")]
        [Required]
        public int productId { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string name { get; set; }


        [Column("description")]
        [StringLength(100)]
        public string description { get; set; }


        [Column("interestPercents")]
        [Required]
        public float interestPercents { get; set; }

        [Column("deposit")]
        [Required]
        public float deposit { get; set; }


        [Column("date")]
        [Required]
        public DateTime date { get; set; }

    }
