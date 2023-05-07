using OCP_Employee.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Employee.Account
{
    internal class Employee:IEntity
    {
        public Employee()
        {
            GenerateAccount = new Account();
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public IAccount GenerateAccount { get; set; }

        public bool IsManager { get; set; }
    }
}
