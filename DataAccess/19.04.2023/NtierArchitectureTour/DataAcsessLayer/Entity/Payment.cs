using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entity
{
    public class Payment:BaseClass
    {
        public DateTime PaymentDate { get; set; }
        public decimal Price { get; set; }

        //Mapping

        public List<Reservation> Reservations { get; set; }
    }
}
