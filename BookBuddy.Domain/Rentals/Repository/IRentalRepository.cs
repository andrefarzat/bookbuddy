using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookBuddy.Domain.Rentals.Repository
{
    public interface IRentalRepository : IRepository<Rental>
    {
        // Add rental-specific repository methods here if needed
    }
}
