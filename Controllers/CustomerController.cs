using Microsoft.AspNetCore.Mvc;
using MStraning_customer.Domain.Models;
using MStraning_customer.Mapper;
using MStraning_customer.Persistence.CustomerRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MStraning_customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _CostumerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _CostumerRepository = customerRepository;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var customersEF = _CostumerRepository.GetAllCustomers();

            return CustomerMapper.Map(customersEF);
        }

        [HttpPost]
        public void Post(Customer customer)
        {
            _CostumerRepository.CreateCustomer(CustomerMapper.Map(customer));

        }

        [HttpPut]
        public void Edit(Customer customer)
        {
            _CostumerRepository.EditCustomer(CustomerMapper.Map(customer),customer.Id);

        }

    }
}
