using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvidersAPI.Models;
using ProvidersAPI.Services;

namespace ProvidersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {

        private readonly IProviderService _providerService;

        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }

        // GET: api/provider
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Provider>>> GetAll()
        {
            var providers = await _providerService.GetAllAsync();
            return Ok(providers);
        }

        // GET: api/provider/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Provider>> GetById(int id)
        {
            var provider = await _providerService.GetByIdAsync(id);
            if (provider == null)
                return NotFound();

            return Ok(provider);
        }

        // POST: api/provider
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Provider provider)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _providerService.AddAsync(provider);

            return CreatedAtAction(nameof(GetById), new { id = provider.Id }, provider);
        }

        // PUT: api/provider/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] Provider provider)
        {
            if (id != provider.Id)
                return BadRequest("ID mismatch");

            var existing = await _providerService.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            await _providerService.UpdateAsync(provider);
            return NoContent(); // 204
        }

        // DELETE: api/provider/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existing = await _providerService.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            await _providerService.DeleteAsync(id);
            return NoContent(); // 204
        }
    }
}
