using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.ViewModels
{
    public class PaymentVM
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {PaymentDate} {Price}";
        }
    }
}
