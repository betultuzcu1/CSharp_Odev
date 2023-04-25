using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entity
{
    public class Tour:BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public short Capacity { get; set; }

        //Mapping
        public int GuideId { get; set; }
        public int TourLocationId { get; set; }
        public int TourTypeId { get; set; }
        public Guide Guide { get; set; }
        public TourLocation TourLocation { get; set; }
        public TourType TourType { get; set; }

        public List<Reservation> Reservations { get; set; }

    }
}
