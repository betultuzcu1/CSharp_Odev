using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.ViewModels
{
    public class GuideVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} {FullName} {EMail} {PhoneNumber} {Salary}";
        }
    }
}
