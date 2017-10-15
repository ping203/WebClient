using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Model.Models
{
    [Table("HoanVies")]
    public class HoanVi
    {
        public int HV1 { set; get; }

        public int HV2 { set; get; }

        public int HV3 { set; get; }

        public int HV4 { set; get; }
    }
}
