using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace VoyagerYDAL
{
    public class BaseRepo<T> : IRepo<T> where T : class
    {
        private VoyagerYContext db;

        public BaseRepo(DbContext voyagerYContext)
        {
            db = (VoyagerYContext)voyagerYContext;
        }

        public T Add(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
            return item;
        }

        public IList<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            Type type = typeof(T);
            PropertyInfo PI = type.GetProperty("Id");
            return db.Set<T>().SingleOrDefault(x => Id == (int)PI.GetValue(x));
        }

        public void Remove(T item)
        {
            db.Set<T>().Remove(item);
            db.SaveChanges();
        }

        public void Update(T item)
        {
            db.Entry<T>(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
