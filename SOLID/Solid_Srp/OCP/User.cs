using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class User
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public EmployeeType Type { get; set; }
    }
}
