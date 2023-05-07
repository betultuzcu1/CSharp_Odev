using OCP_Employee.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Employee.Account
{
    internal class Manager:IEntity
    {
        public Manager()
        {
            GenerateAccount = new ManagerAccount();
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public IAccount GenerateAccount { get; set; }
    }
}
