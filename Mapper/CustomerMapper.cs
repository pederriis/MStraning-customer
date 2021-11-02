using MStraning_customer.Domain.Models;
using MStraning_customer.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MStraning_customer.Mapper
{
    public static class CustomerMapper
    {

        public static IEnumerable<Customer> Map(IEnumerable<CustomerEF> customerEFList)
        {
            List<Customer> customers = new List<Customer>();

            foreach (var c in customerEFList)
            {
                customers.Add(Map(c));
            }

            return customers;

        }

        public static Customer Map(CustomerEF customerEF)
        {
            Customer customer = new Customer
            {
                Id = customerEF.Id,
                Name = customerEF.Name,
                PhoneNumber = customerEF.PhoneNumber,
            };



            return customer;

        }
        public static CustomerEF Map(Customer customer)
        {
            CustomerEF customerEF = new CustomerEF
            {
               // Id = customer.Id,
                Name = customer.Name,
                PhoneNumber = customer.PhoneNumber,
            };



            return customerEF;

        }

    }
}
