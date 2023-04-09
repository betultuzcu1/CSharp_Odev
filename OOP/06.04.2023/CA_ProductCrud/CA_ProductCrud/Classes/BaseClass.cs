using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ProductCrud.Classes
{
    internal class BaseClass
    {
        //todo: her bir nesne oluşturulduğunda ID otomatik artacak.
        public BaseClass()
        {

            CreatedDate = DateTime.Now;
            IsActive = true;
        }
        private int sayac = 0;
        public int ID { get { return sayac++; }  }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
