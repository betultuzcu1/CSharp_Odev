using OCP_Employee.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Employee.Abstract
{
    internal interface IAccount
    {
        Employee Create(IEntity entity);
    }
}
