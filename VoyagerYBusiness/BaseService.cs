using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerYDAL;

namespace VoyagerYBusiness
{
    public class BaseService<T> : IService<T> where T : class
    {
        public Data data = new Data();


        public virtual T Add(T item)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> GetAll()
        {

            throw new NotImplementedException();
        }

        public virtual T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
