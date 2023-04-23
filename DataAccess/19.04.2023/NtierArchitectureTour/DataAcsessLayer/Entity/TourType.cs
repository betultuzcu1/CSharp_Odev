using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entity
{
    public class TourType:BaseClass
    {
        public string Name { get; set; }
       

        //Mapping

        public List<Tour> Tours { get; set; }
    }
}
