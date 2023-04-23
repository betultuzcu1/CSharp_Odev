using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.ViewModels
{
    public class TourVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public short Capacity { get; set; }
        public int GuideId { get; set; }
        public int TourLocationId { get; set; }
        public int TourTypeId { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Description} {StartDate} {EndDate} {Price} {Capacity} {GuideId} {TourLocationId} {TourTypeId}";
        }
    }
}
