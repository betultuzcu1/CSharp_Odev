using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.ViewModels
{
    public class ReservationVM
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public int TourId { get; set; }

        public override string ToString()
        {
            return $"{Id} {ReservationDate} {TotalPrice} {CustomerId} {PaymentId} {TourId}";
        }
    }
}
