using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entity
{
    public class Reservation:BaseClass
    {
        //public DateTime ReservationDate { get; set; }
        public decimal TotalPrice { get; set; }

        //Mapping
        public int CustomerId { get; set; }

        public int PaymentId { get; set; }
        public int TourId { get; set; }

        public Payment Payment { get; set; }
        public Customer Customer { get; set; }
        public Tour Tour { get; set; }
    }
}
