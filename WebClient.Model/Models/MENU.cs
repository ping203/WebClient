
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("MENUS")]
    public class MENU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string URL { set; get; }

        [Required]
        public int IDGroup { set; get; }

        [MaxLength(10)]
        public string Target { set; get; }

        [Required]
        public bool Active { set; get; }
    }
}
