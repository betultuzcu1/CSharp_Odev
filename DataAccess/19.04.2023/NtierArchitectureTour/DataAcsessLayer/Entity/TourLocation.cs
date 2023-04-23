using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entity
{
    public class TourLocation:BaseClass
    {
        public string City { get; set; }
        public string Country { get; set; }

        //Mapping
        public List<Tour> Tours { get; set; }
    }
}
