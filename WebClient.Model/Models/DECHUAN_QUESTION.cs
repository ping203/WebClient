using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("DECHUAN_QUESTIONS")]
    public class DECHUAN_QUESTION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDAuto { set; get; }

        [Key]
        public int MaDe { set; get; }

        [Key]
        public Guid QuesID { set; get; }

        [Required]
        public int QID { set; get; }

        [ForeignKey("MaDe")]
        public virtual DECHUAN MaDeChuan { set; get; }

        [ForeignKey("QuestionID")]
        public virtual Question QuestionID { set; get; }
    }
}
