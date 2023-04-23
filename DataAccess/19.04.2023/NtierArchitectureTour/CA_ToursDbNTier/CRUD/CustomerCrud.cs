using BusinessLogicLayer.DesingPatterns.GenericRepository.ConcRep;
using CA_ToursDbNTier.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ToursDbNTier.CRUD
{
    internal class CustomerCrud
    {
        CustomerRepository _customerRepository;
        public CustomerCrud() 
        { 
            _customerRepository = new CustomerRepository();
        }

        void ListCustomers()
        {
           
        }
    }
}
