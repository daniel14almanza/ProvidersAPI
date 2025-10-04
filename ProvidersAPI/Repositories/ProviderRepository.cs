using ProvidersAPI.Data;
using ProvidersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvidersAPI.Repositories
{
    public class ProviderRepository : IProviderRepository
    {

        private readonly ApplicationDbContext _context;

        public ProviderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Provider provider)
        {
            provider.LastEdited = DateTime.UtcNow;

            _context.Providers.Add(provider);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var provider = await _context.Providers.FindAsync(id);
            if (provider != null)
            {
                _context.Providers.Remove(provider);
                await _context.SaveChangesAsync();
            }

        }

        /*
        public async Task<IEnumerable<Provider>> GetAllAsync() => await _context.Providers.ToListAsync();
        */
        public async Task<IEnumerable<Provider>> GetAllAsync()
        {
            return await _context.Providers
                .OrderByDescending(p => p.LastEdited)
                .ToListAsync();
        }

        public async Task<Provider?> GetByIdAsync(int id) => await _context.Providers.FindAsync(id);

        public async Task UpdateAsync(Provider updatedProvider)
        {
            /*
            _context.Providers.Update(provider);
            await _context.SaveChangesAsync();
            */

            var existingProvider = await _context.Providers.FindAsync(updatedProvider.Id);
            if (existingProvider == null) return;

            // Update fields manually
            existingProvider.LegalName = updatedProvider.LegalName;
            existingProvider.TradeName = updatedProvider.TradeName;
            existingProvider.TaxId = updatedProvider.TaxId;
            existingProvider.PhoneNumber = updatedProvider.PhoneNumber;
            existingProvider.Email = updatedProvider.Email;
            existingProvider.Website = updatedProvider.Website;
            existingProvider.Address = updatedProvider.Address;
            existingProvider.Country = updatedProvider.Country;
            existingProvider.AnnualBillingUSD = updatedProvider.AnnualBillingUSD;
            //existingProvider.LastEdited = updatedProvider.LastEdited;
            existingProvider.LastEdited = DateTime.UtcNow;


            await _context.SaveChangesAsync();

        }
    }
}
