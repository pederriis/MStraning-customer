using Microsoft.EntityFrameworkCore;
using MStraning_customer.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MStraning_customer.Persistence.Contexts
{
    public class CustomerContext: DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options): base(options)
        {
        }

        public DbSet<CustomerEF> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEF>().ToTable("Customer");
        }
    }
}
