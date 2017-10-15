using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("DETRONS")]
    public class DETRON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string MaDeTron { set; get; }

        [MaxLength(50)]
        public string TenDeTron { set; get; }

        [Required]
        public int MaDeChuan { set; get; }
    }
}
