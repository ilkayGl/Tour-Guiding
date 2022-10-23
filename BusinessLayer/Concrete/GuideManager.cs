using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public List<Guide> GetList()
        {
            return _guideDal.List();
        }

        public void TAdd(Guide t)
        {
            _guideDal.Insert(t);
        }

        public void TDelete(Guide t)
        {
            _guideDal.Delete(t);
        }

        public Guide TGetByID(int id)
        {
            return _guideDal.Get(x => x.GuideID == id);
        }

        public void TUpdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
