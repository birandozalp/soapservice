using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerYEnt
{
    [Table("Buses")]
    public class BusPoc
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Plate { get; set; }
        [ForeignKey("BusType")]
        [Required]
        public int BusTypeId { get; set; }
        public BusTypePoc BusType { get; set; }
    }
}
