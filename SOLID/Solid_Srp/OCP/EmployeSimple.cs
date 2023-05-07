using OCP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class EmployeSimple
    {
        public static Employee CreateEmployee(int id, string firstName, string lastName, string email, EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Menager:
                    return new Menager(id, firstName, lastName, email);
                case EmployeeType.CEO:
                    return new CEO(id, firstName, lastName, email);
                case EmployeeType.Represant:
                    return new Represant(id, firstName, lastName, email);
                default:
                    throw new ArgumentException("Invalid employee type.");
            }
        }
    }
}

