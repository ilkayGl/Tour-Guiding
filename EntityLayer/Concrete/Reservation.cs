using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
        public string PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Status { get; set; }


    }
}
