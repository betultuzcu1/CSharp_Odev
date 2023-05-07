using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Interface
{
    internal interface IEmployeeSimple
    {
        Employee CreateEmployee(int id, string firstName, string lastName, string email);
    }
}
