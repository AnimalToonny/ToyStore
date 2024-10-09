using Microsoft.EntityFrameworkCore;
using ToyStore.Core.Models;
using ToyStore.Core.Repositories;
using ToyStore.DataAccess.Entities;

namespace ToyStore.DataAccess.Repositories
{
    public class ToysRepository : IToysRepository
    {
        private readonly ToyStoreDbContext _context;

        public ToysRepository(ToyStoreDbContext context)
        {
            _context = context;
        }

        public async Task<List<Toy>> Get()
        {
            var toyEntities = await _context.Toys
                .AsNoTracking()
                .ToListAsync();

            var toys = toyEntities
                .Select(t => Toy.Create(t.Id, t.Name, t.Price).Toy)
                .ToList();

            return toys;
        }

        public async Task<Guid> Create(Toy toy)
        {
            var toyEntity = new ToyEntity
            {
                Id = toy.Id,
                Name = toy.Name,
                Price = toy.Price,
            };

            await _context.Toys.AddAsync(toyEntity);
            await _context.SaveChangesAsync();

            return toyEntity.Id;
        }

        public async Task<Guid> Update(Guid id, string name, uint price)
        {
            await _context.Toys
                .Where(t => t.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(t => t.Name, t => name)
                    .SetProperty(t => t.Price, t => price));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Toys
                .Where(t => t.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
