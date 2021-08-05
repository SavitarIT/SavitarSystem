using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Shared;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Savitar.Server.Controllers
{
    public class BaseApiEntityController<TEntity, TRepository> : BaseApiController
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public BaseApiEntityController(TRepository repository)
        {
            _repository = repository;
}

        // GET: api/[controller]
        [HttpGet]
        [ResponseCache(NoStore = false, Duration = 10, Location = ResponseCacheLocation.Any)]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return Ok(await _repository.GetAllAsync());
        }

// GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var movie = Ok(await _repository.GetAsync(id));
            if (movie == null)
                return NotFound();

            return movie;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
{
            if (id != entity.Id)
                return BadRequest();

            await _repository.UpdateAsync(entity);
            return NoContent();
        }

// POST: api/[controller]
[HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await _repository.AddAsync(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

// DELETE: api/[controller]/5
[HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var movie = await _repository.DeleteAsync(id);
            if (movie == null)
                return NotFound();

            return movie;
        }
    }
}
