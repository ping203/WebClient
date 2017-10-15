using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("POSTTAGs")]
    public class POSTTAG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPost { set; get; }

        [Required]
        public int IDTag { set; get; }
    }
}
