using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("DECHUANS")]
    public class DECHUAN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDeChuan { set; get; }

        [MaxLength(50)]
        public string TenDeChuan { set; get; }

        [Required]
        public Guid MaMon { set; get; }

        [Required]
        public int MaCaThi { set; get; }

        [Required]
        public int SoDeHoanVi { set; get; }

        public bool TrangThaiTron { set; get; }

        [Required]
        public int ThoiGian { set; get; }

        public bool Lock { set; get; }
    }
}
