using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        protected virtual void ConfigureQuery(ref IQueryable<TEntity> data) { }

        public virtual async Task<IList<TEntity>> GetAllAsync()
        {
            var data = await Repository.GetAllAsync();
            ConfigureQuery(ref data);

            return await data.ToListAsync();
        }

        // GET: api/[controller]
        [HttpGet]
#if !DEBUG
        [ResponseCache(NoStore = false, Duration = 120, Location = ResponseCacheLocation.Any)]
#endif
        public async Task<ActionResult<IList<TEntity>>> Get()
        {
            return Ok(await GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var item = Ok(await Repository.GetAsync(id));
            if (item == null)
                return NotFound();

            return item;
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await Repository.AddAsync(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // PUT: api/[controller]/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
{
            if (id != entity.Id)
                return BadRequest();

            await Repository.UpdateAsync(entity);
            return NoContent();
        }

// DELETE: api/[controller]/5
[HttpDelete("{id:int}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var movie = await Repository.DeleteAsync(id);
            if (movie == null)
                return NotFound();

            return movie;
        }
    }
}
