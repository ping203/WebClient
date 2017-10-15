using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("QUESTION_BUIES")]
    public class QUESTION_BUY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public int IDQClass { set; get; }

        [Required]
        public int CountQS { set; get; }

        [Required]
        public int IDUser { set; get; }

        [Required]
        public float Fee { set; get; }

        [Required]
        public int IDHinhThucTra { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
