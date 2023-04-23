using DataAcsessLayer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entity
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;

        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
