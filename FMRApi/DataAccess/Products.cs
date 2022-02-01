using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

  
    [Table("Products")]
    public class Products : Base
    {
        [Column("customerId")]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption
        //.Identity)]
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
        public decimal interestPercents { get; set; }

        [Column("deposit")]
        [Required]
        public decimal deposit { get; set; }


        [Column("date")]
        [Required]
        public DateTime date { get; set; }

    }
