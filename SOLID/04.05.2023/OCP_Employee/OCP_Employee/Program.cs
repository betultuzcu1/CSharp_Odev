using OCP_Employee.Abstract;
using OCP_Employee.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEntity> persons = new List<IEntity>()
            {
                //Employee
                new Manager{Firstname="Nancy",Lastname="Davolio"},

                //Manager
                new Employee{Firstname="Andrew",Lastname="Fuller"},
            };

            List<Employee> employees = new List<Employee>();



            foreach (var p in persons)
            {
                employees.Add(p.GenerateAccount.Create(p));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"Ad:{employee.Firstname} Soyad:{employee.Lastname} Manager:{employee.IsManager} ");
            }


            Console.Read();
        }
    }
}
