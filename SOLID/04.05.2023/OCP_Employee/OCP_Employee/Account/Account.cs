using OCP_Employee.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Employee.Account
{
    internal class Account:IAccount
    {
        public Employee Create(IEntity entity)
        {
            Employee employee = new Employee();
            employee.Firstname = entity.Firstname;
            employee.Lastname = entity.Lastname;

            return employee;
        }
    }
}
