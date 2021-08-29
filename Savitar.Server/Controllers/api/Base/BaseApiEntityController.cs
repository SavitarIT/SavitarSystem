using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Shared;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Web.Server.Controllers.api.Base
{
    public abstract class BaseApiEntityController<TEntity, TController> : BaseApiController<TController>
        where TEntity : class, IEntity
    {
        protected IRepository<TEntity> Repository { get; }

        protected BaseApiEntityController(IRepository<TEntity> repository)
        {
            Repository = repository;
}

        protected virtual IEnumerable<TEntity> ConfigureGetAll(IEnumerable<TEntity> data)
        {
            return data;
        }

        // GET: api/[controller]
        [HttpGet]
        [ResponseCache(NoStore = false, Duration = 120, Location = ResponseCacheLocation.Any)]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            var data = await Repository.GetAllAsync();
            ConfigureGetAll(data);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var movie = Ok(await Repository.GetAsync(id));
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

            await Repository.UpdateAsync(entity);
            return NoContent();
        }

// POST: api/[controller]
[HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await Repository.AddAsync(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

// DELETE: api/[controller]/5
[HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var movie = await Repository.DeleteAsync(id);
            if (movie == null)
                return NotFound();

            return movie;
        }
    }
}
