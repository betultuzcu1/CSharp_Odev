using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entity
{
    public class Guide:BaseClass
    {
        public string FullName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }

        //Mapping
        public List<Tour> Tours { get; set; }
    }
}
