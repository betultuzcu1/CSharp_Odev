using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = EmployeSimple.CreateEmployee(1, "John", "Doe", "john.doe@employee.com", EmployeeType.Menager);

            Console.WriteLine($"{newEmployee.Id} {newEmployee.FirstName} {newEmployee.LastName} {newEmployee.Email} {newEmployee.Type}");

            Console.ReadLine();

        }
    }
}
