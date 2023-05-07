using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Represant:Employee
    {
        public Represant(int id, string firstName, string lastName, string email)
        : base(id, firstName, lastName, email)
        {
            Type = EmployeeType.Represant;
        }

        public override bool IsMenager()
        {
            return false;
        }

        public override bool IsCeo()
        {
            return false;
        }

        public override bool IsRepresentative()
        {
            return true;
        }
    }
}
