using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLatterManager : INewsLatterService
    {
        private readonly INewsLatterDal _newsLatterDal;

        public NewsLatterManager(INewsLatterDal newsLatterDal)
        {
            _newsLatterDal = newsLatterDal;
        }

        public List<NewsLatter> GetList()
        {
            return _newsLatterDal.List();
        }

        public void TAdd(NewsLatter t)
        {
            _newsLatterDal.Insert(t);
        }

        public void TDelete(NewsLatter t)
        {
            _newsLatterDal.Delete(t);
        }

        public NewsLatter TGetByID(int id)
        {
            return _newsLatterDal.Get(x => x.NewslatterID == id);
        }

        public void TUpdate(NewsLatter t)
        {
            _newsLatterDal.Update(t);
        }
    }
}
