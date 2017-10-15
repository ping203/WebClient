using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("DETRON_QUESTIONS")]
    public class DETRON_QUESTION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDAuto { set; get; }

        [Key]
        public int IDDeTron { set; get; }

        [Key]
        public Guid QuestionID { set; get; }

        [Required]
        public int Answer1 { set; get; }

        [Required]
        public int Answer2 { set; get; }

        [Required]
        public int Answer3 { set; get; }

        [Required]
        public int Answer4 { set; get; }

        [Required]
        public int DapAn { set; get; }

        public int TheAnswer { set; get; }
    }
}
