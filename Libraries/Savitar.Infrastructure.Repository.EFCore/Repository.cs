using Savitar.Domain.Shared;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public class Repository<TEntity> : BaseRepository<TEntity, ApplicationDbContext>
        where TEntity : class, IEntity
    {
        public Repository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
