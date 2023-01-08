using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using var c = new Context();
            return c.Reservations.Include(x => x.Destination).ToList().Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList().OrderByDescending(x => x.CreationDate).ToList();



        }
    }
}
