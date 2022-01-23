using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//namespace FMRApi.DataAccess
//{

    public class Base
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption
        .Identity)]
        [Required]
        [StringLength(100)]
        public string id { get; set; }


        [Column("updateDate")]
        [Required]
        public int updateDate { get; set; }


        [Column("isDeleted")]
        [Required]
        public Boolean isDeleted { get; set; }

    }
