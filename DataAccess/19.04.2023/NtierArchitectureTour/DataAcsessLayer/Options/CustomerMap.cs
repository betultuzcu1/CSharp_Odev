using DataAcsessLayer.Entity;
using DataAcsessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAcsessLayer.Options
{
    public class CustomerMap:BaseMap<Customer>
    {
        public CustomerMap() 
        {
            Property(x=>x.FullName).HasMaxLength(250).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsOptional();
            Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired();

        }
    }
}
