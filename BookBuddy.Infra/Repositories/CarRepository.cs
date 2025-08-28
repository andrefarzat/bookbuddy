using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookBuddy.Domain.Cars;

namespace BookBuddy.Infra.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly BookBuddyDbContext _context;
        public CarRepository(BookBuddyDbContext context)
        {
            _context = context;
        }

        public async Task<Car?> GetByIdAsync(Guid id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.ToListAsync(_context.Cars);
        }

        public async Task AddAsync(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Car car)
        {
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }
    }
}
