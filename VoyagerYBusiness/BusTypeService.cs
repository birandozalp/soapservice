using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerYBusiness
{
    public class BusTypeService : BaseService<BusType>, IService<BusType>
    {
        

        public override IList<BusType> GetAll()
        {
            List<BusType> busTypes = new List<BusType>();
            var typelist = data.busTypeRepo.GetAll();
            foreach (var item in typelist)
            {
                BusType busType = new BusType();
                busType.Name = item.BusTypeName;
                busTypes.Add(busType);
            }
            return busTypes;
        }
    }
}
