using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.ViewModels
{
    public class TourLocationVM
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Id} {City} {Country}";
        }
    }
}
