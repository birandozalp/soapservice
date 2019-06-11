using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerYEnt;

namespace VoyagerYBusiness
{
    public delegate void ListChangeHandler();

    public class BusService : BaseService<Bus>, IService<Bus>
    {

        public event ListChangeHandler ListChanged;

        public override IList<Bus> GetAll()
        {
            List<Bus> Buses = new List<Bus>();
            var busPOCs = data.busRepo.GetAll();
            var busTypePOCs = data.busTypeRepo.GetAll();


            foreach (var item in busPOCs)
            {
                Bus currentBus = new Bus();
                BusType currentBusType = new BusType();
                currentBus.Id = item.Id;
                currentBus.Make = item.Make;
                currentBus.Plate = item.Plate;
                currentBusType.Name = busTypePOCs.SingleOrDefault(x => x.BusTypeId == item.BusTypeId).BusTypeName;
                currentBus.Type = currentBusType;
                Buses.Add(currentBus);
            }

            return Buses;
        }

        public override Bus Add(Bus item)
        {
            var typelist = data.busTypeRepo.GetAll();

            BusPoc busPoc = new BusPoc();
            BusTypePoc busTypePoc = new BusTypePoc();
            busPoc.Make = item.Make;
            busPoc.Plate = item.Plate;
            busPoc.BusTypeId = typelist.SingleOrDefault(x => x.BusTypeName == item.Type.Name).BusTypeId;

            busPoc.BusType = typelist.SingleOrDefault(x => x.BusTypeName == item.Type.Name);


            data.busRepo.Add(busPoc);
            ListChanged();
            return item;
        }

        public override void Remove(Bus item)
        {
            var buslist = data.busRepo.GetAll();
      
            data.busRepo.Remove(buslist.SingleOrDefault(x => x.Id == item.Id));

            ListChanged();
        }

        public override void Update(Bus item)
        {
            var typelist = data.busTypeRepo.GetAll();
            var result = data.busRepo.GetAll().SingleOrDefault(x => x.Id == item.Id);
            result.Make = item.Make;
            result.Plate = item.Plate;
            result.BusTypeId = typelist.SingleOrDefault(x => x.BusTypeName == item.Type.Name).BusTypeId;
            data.busRepo.Update(result);
            ListChanged();
        }

        public override Bus GetById(int Id)
        {
            var BusList = data.busRepo.GetAll();
            var BusTypeList = data.busTypeRepo.GetAll();
            var curbuspoc = BusList.SingleOrDefault(x => x.Id == Id);

            Bus bus = new Bus();
            bus.Make = curbuspoc.Make;
            bus.Plate = curbuspoc.Plate;
            BusType bustype = new BusType();
            bustype.Name = BusTypeList.SingleOrDefault(x => x.BusTypeId == curbuspoc.BusTypeId).BusTypeName;
            bus.Type = bustype;
            return bus;
        }
    }
}
