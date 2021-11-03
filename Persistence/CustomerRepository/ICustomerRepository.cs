using MStraning_customer.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MStraning_customer.Persistence.CustomerRepository
{
   public interface ICustomerRepository
    {
        IEnumerable<CustomerEF> GetAllCustomers();

        CustomerEF GetSingleCustomer(int customerId);

        void CreateCustomer(CustomerEF customerEF);

        void EditCustomer(CustomerEF customerEF, int customerId);
    }
}
