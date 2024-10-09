using ToyStore.Core.Models;

namespace ToyStore.Core.Repositories
{
    public interface IToysRepository
    {
        Task<Guid> Create(Toy toy);
        Task<Guid> Delete(Guid id);
        Task<List<Toy>> Get();
        Task<Guid> Update(Guid id, string name, uint price);
    }
}