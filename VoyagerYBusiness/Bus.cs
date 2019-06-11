using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerYBusiness
{
    public class Bus
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Plate { get; set; }
        public BusType Type { get; set; }
        public bool HasToilet
        {
            get
            {
                if (this.Type.Name == "Luxury")
                { return true; }
                else
                { return false; }
            }
        }
        public int Capacity
        {
            get
            {
                if (this.Type.Name == "Luxury")
                {
                    return 25;
                }
                else
                {
                    return 30;
                }
            }
        }
    }
}
