using DataAcsessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Options
{
    public class GuideMap:BaseMap<Guide>
    {
        public GuideMap() 
        {
            Property(x => x.FullName).HasMaxLength(250).IsRequired();
            Property(x => x.EMail).HasMaxLength(50).IsOptional();
            Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired();
            Property(x => x.Salary).IsRequired();
        }
    }
}
