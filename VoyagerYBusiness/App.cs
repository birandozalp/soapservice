using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerYBusiness
{
    public class App
    {

        public BusService busService { get; set; }
        public BusTypeService busTypeService { get; set; }

        public App()
        {
            busService = new BusService();
            busTypeService = new BusTypeService();
        }



        //public Data repos { get; set; }
        //public List<Bus> Buses { get; set; }

        //public App()
        //    {
        //    repos = new Data();
        //    var busPOCs = repos.busRepo.GetAll();
        //    var busTypePOCs = repos.busTypeRepo.GetAll();

        //    foreach (var item in busPOCs)
        //    {
        //        Bus currentBus = new Bus();
        //        BusType currentBusType = new BusType();
        //        currentBus.Make = item.Make;
        //        currentBus.Plate = item.Plate;
        //        currentBusType.Name = busTypePOCs.SingleOrDefault(x => x.BusTypeId == item.Id).BusTypeName;
        //        Buses.Add(currentBus);
        //    }


    }
}
