using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerYBusiness
{
    public interface IService<T>
    {
        void Remove(T item);

        void Update(T item);

        T GetById(int Id);

        T Add(T item);

        IList<T> GetAll();
    }
}
