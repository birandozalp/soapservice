using System;
using System.Collections.Generic;
using System.Text;
using VoyagerYEnt;

namespace VoyagerYDAL
{
    public class Data
    {
        private VoyagerYContext dbContext;

        public IRepo<BusPoc> busRepo { get; set; }
        public IRepo<BusTypePoc> busTypeRepo { get; set; }

        public Data()
        {
            dbContext = new VoyagerYContext();

            busRepo = new BusRepo(dbContext);
            busTypeRepo = new BusTypeRepo(dbContext);

            var List = busTypeRepo.GetAll(); /////DEBUG İÇİN

        }
    }
}
