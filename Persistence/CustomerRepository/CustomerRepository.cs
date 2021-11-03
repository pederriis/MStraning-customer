using MStraning_customer.Persistence.Contexts;
using MStraning_customer.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MStraning_customer.Persistence.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _Context;
        public CustomerRepository(CustomerContext context)
        {
            _Context = context;
        }

      

        public IEnumerable<CustomerEF> GetAllCustomers()
        {
            var customers = _Context.Customers.ToList();

            return customers;
        }

        public CustomerEF GetSingleCustomer(int customerId)
        {
            var customers = _Context.Customers.FirstOrDefault(x=>x.Id==customerId);

            return customers;
        }

        public void CreateCustomer(CustomerEF customerEF)
        {
            _Context.Add(customerEF);

            _Context.SaveChanges();
            
        }

        public void EditCustomer(CustomerEF customerEF, int customerId)
        {
            CustomerEF customer =_Context.Customers.FirstOrDefault(x => x.Id == customerId);

            customer.Name=customerEF.Name;
            customer.PhoneNumber = customerEF.PhoneNumber;


            _Context.SaveChanges();
        }
    }
}
