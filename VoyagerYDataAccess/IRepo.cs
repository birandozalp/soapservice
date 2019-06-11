using System;
using System.Collections.Generic;
using System.Text;

namespace VoyagerYDAL
{
    public interface IRepo<T>
    {
        void Remove(T item);

        void Update(T item);

        T GetById(int Id);

        T Add(T item);

        IList<T> GetAll();
    }
}
