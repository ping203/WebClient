using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("VISITOR_STATISTICS")]
    public class VISITOR_STATISTIC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { set; get; }

        [Required]
        public DateTime VisitedDate { set; get; }

        [Required]
        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
