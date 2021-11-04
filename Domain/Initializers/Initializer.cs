using MStraning_customer.Persistence.Contexts;
using MStraning_customer.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MStraning_customer.Domain.Initializers
{
    public class Initializer
    {


        public static void SeedDatabase(CustomerContext customerContext)
        {
            //sikrer sig at databasen eksisterer og skaber, den hvis den ikke gør
            customerContext.Database.EnsureCreated();

            //seeder databasen, hvis den er tom
            if (!customerContext.Customers.Any())
            {

                List<CustomerEF> customers = new List<CustomerEF> {
                new CustomerEF { Name = "Hans", PhoneNumber="566" },
                new CustomerEF { Name = "Ole", PhoneNumber="987"},

            };

                foreach (var c in customers)
                {
                    customerContext.Add(c);
                }
                customerContext.SaveChanges();
            }

        }
    }
}
