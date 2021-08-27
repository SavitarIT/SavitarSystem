using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Shared;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Server.Controllers.api.Base
{
    public class ApiEntityController<TEntity, TRepository> : ApiController
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        protected readonly TRepository _repository;

        public ApiEntityController(TRepository repository)
        {
            _repository = repository;
}

        protected virtual IEnumerable<TEntity> ConfigureGetAll(IEnumerable<TEntity> data)
        {
            return data;
        }

        // GET: api/[controller]
        [HttpGet]
        [ResponseCache(NoStore = false, Duration = 120, Location = ResponseCacheLocation.Any)]
        public async virtual Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            var data = await _repository.GetAllAsync();
            ConfigureGetAll(data);
            return Ok(data);
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
