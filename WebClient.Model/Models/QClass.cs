using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("QClasses")]
    public class QClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ClassID { set; get; }

        public Guid SubjectID { set; get; }

        public int ClassNbr { set; get; }

        [MaxLength(200)]
        public string Descr { set; get; }

        [MaxLength(100)]
        public string ChuThich { set; get; }
        
        public bool TrangThai { set; get; }
    }
}
