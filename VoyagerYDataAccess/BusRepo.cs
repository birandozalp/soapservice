using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using VoyagerYEnt;

namespace VoyagerYDAL
{
    public class BusRepo : BaseRepo<BusPoc>, IRepo<BusPoc>
    {
        public BusRepo(DbContext voyagerYContext) : base(voyagerYContext)
        {

        }
    }
}
