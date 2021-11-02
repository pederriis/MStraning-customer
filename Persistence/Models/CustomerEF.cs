using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MStraning_customer.Persistence.Models
{
    public class CustomerEF: ICustomerEF
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
