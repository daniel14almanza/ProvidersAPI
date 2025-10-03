using ProvidersAPI.Models;

namespace ProvidersAPI.Services
{
    public interface IProviderService
    {
        Task<IEnumerable<Provider>> GetAllAsync();
        Task<Provider?> GetByIdAsync(int id);
        Task AddAsync(Provider provider);
        Task UpdateAsync(Provider provider);
        Task DeleteAsync(int id);
    }
}
