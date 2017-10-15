using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebClient.Model.Abstract;

namespace WebClient.Model.Models
{
    [Table("POSTs")]
    public class POST:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
        [MaxLength(200)]
        public string Image { set; get; }

        [Required]
        [MaxLength(500)]
        public string Description { set; get; }

        [Required]
        [MaxLength(500)]
        public string Content { set; get; }

        [Required]
        public bool HomeFlag { set; get; }

        [Required]
        public bool HotFlag { set; get; }

        [Required]
        public bool ViewCount { set; get; }
    }
}
