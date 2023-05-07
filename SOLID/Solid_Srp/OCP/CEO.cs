using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class CEO : Employee
    {
        public CEO(int id, string firstName, string lastName, string email)
        : base(id, firstName, lastName, email)
        {
            Type = EmployeeType.CEO;
        }

        public override bool IsMenager()
        {
            return false;
        }

        public override bool IsCeo()
        {
            return true;
        }

        public override bool IsRepresentative()
        {
            return false;
        }
    }
}
