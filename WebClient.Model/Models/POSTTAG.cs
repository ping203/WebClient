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
        [Column(Order = 1)]
        public int IDPost { set; get; }

        [Key]
        [Column(TypeName = "int", Order = 2)]
        public int IDTag { set; get; }

        [ForeignKey("IDPost")]
        public virtual POST Post { set; get; }

        [ForeignKey("IDTag")]
        public virtual TAG Tag { set; get; }
    }
}
