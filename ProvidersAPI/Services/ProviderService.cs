using ProvidersAPI.Models;
using ProvidersAPI.Repositories;

namespace ProvidersAPI.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _repository;

        public ProviderService(IProviderRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Provider>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Provider?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Provider provider)
        {
            await _repository.AddAsync(provider);
        }

        public async Task UpdateAsync(Provider provider)
        {
            await _repository.UpdateAsync(provider);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
