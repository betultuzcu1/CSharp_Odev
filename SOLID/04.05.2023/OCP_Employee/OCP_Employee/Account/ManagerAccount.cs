using OCP_Employee.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Employee.Account
{
    internal class ManagerAccount:IAccount
    {
        public Employee Create(IEntity entity)
        {
            Employee employee = new Employee();
            employee.Firstname = entity.Firstname;
            employee.Lastname = entity.Lastname;
            employee.IsManager = true;
            employee.Email = entity.Firstname.Substring(0, 1) + entity.Lastname.ToString() + "@bilgeadam.com";
            return employee;
        }
    }
}
