using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookBuddy.Domain.Rentals;
using BookBuddy.Domain;

namespace BookBuddy.Infra.Repositories
{
    public class RentalRepository : IRentalRepository
    {
        private readonly BookBuddyDbContext _context;
        public RentalRepository(BookBuddyDbContext context)
        {
            _context = context;
        }

        public async Task<Rental?> GetByIdAsync(Guid id)
        {
            return await _context.Rentals.FindAsync(id);
        }

        public async Task<IEnumerable<Rental>> GetAllAsync()
        {
            return await Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.ToListAsync(_context.Rentals);
        }

        public async Task AddAsync(Rental rental)
        {
            await _context.Rentals.AddAsync(rental);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Rental rental)
        {
            _context.Rentals.Update(rental);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var rental = await _context.Rentals.FindAsync(id);
            if (rental != null)
            {
                _context.Rentals.Remove(rental);
                await _context.SaveChangesAsync();
            }
        }
    }
}
