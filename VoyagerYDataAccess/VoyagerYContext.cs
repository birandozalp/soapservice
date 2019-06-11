using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using VoyagerYEnt;

namespace VoyagerYDAL
{
    public class VoyagerYContext : DbContext
    {
  
        public VoyagerYContext() : base("VoyagerYConnection")
        {

        }

        public DbSet<BusPoc> Buses { get; set; }
        public DbSet<BusTypePoc> BusTypes { get; set; }

    }
}