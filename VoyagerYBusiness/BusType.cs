using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerYBusiness
{
    public class BusType
    {
        public string Name { get; set; }

        public override string ToString()
        {
           return this.Name;
        }
    }
}
