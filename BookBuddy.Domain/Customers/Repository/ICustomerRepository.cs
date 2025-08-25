using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookBuddy.Domain.Customers.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        // Add customer-specific repository methods here if needed
    }
}
