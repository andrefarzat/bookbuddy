using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookBuddy.Domain.Cars.Repository
{
    public interface ICarRepository : IRepository<Car>
    {
        // Add car-specific repository methods here if needed
    }
}
