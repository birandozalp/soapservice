using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using VoyagerYEnt;

namespace VoyagerYDAL
{
    public class BusTypeRepo : BaseRepo<BusTypePoc>, IRepo<BusTypePoc>
    {
        public BusTypeRepo(DbContext voyagerYContext) : base(voyagerYContext)
        {

        }
    }
}
