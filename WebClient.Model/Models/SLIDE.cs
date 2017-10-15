using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WebClient.Model.Models
{
    [Table("SLIDES")]
    public class SLIDE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        public string Description { set; get; }

        [Required]
        [MaxLength(200)]
        public string Image { set; get; }

        [Required]
        [MaxLength(500)]
        public string URL { set; get; }

        [Required]
        public bool Active { set; get; }
    }
}
