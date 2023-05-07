using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Employee.Abstract
{
    internal interface IEntity
    {
        string Firstname { get; set; }
        string Lastname { get; set; }

        IAccount GenerateAccount { get; set; }
    }
}
