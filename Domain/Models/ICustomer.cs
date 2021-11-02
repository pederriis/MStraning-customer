using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MStraning_customer.Domain.Models
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
    }
}
