using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCrud.Classes
{
    internal class BaseClass
    {
        public BaseClass()
        {

            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        
        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
