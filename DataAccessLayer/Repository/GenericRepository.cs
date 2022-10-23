using DataAccessLayer.Concrete;
using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {


        public void Delete(T p)
        {
            using Context c = new();
            c.Remove(p);
            c.SaveChanges();

        }

        public List<T> FilterList(Expression<Func<T, bool>> filter)
        {
            using Context c = new();
            return c.Set<T>().Where(filter).ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {

            using Context c = new();
            return c.Set<T>().SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            using Context c = new();
            c.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            using Context c = new();
            return c.Set<T>().ToList();
        }

        public void Update(T p)
        {
            using Context c = new();
            c.Update(p);
            c.SaveChanges();

        }
    }
}
