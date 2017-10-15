using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("SYSTEMCONFIGS")]
    public class SYSTEMCONFIG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }


        [Required]
        [MaxLength(50)]
        public string Code { set; get; }

        [Required]
        [MaxLength(50)]
        public string ValueString { set; get; }

        [Required]
        public int ValueInt { set; get; }
    }
}
