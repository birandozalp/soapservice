using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerYEnt
{
    [Table("BusTypes")]
    public class BusTypePoc
    {
        [Key]
        public int BusTypeId { get; set; }
        [Required]
        public string BusTypeName { get; set; }
    }
}
