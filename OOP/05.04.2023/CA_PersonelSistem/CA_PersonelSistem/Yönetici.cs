﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_PersonelSistem
{
    internal class Yönetici:Personel
    {
        public override decimal Price()
        {
            return Salary * 1.50m;
        }
    }
}
