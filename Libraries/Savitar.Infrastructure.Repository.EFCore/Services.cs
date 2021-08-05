using Savitar.Domain.Models;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Infrastructure.Repository.EFCore
{
    internal class ServiceRepository : Repository<Service, ApplicationDbContext>, IServicesRepository
    {
        public ServiceRepository(ApplicationDbContext context) : base(context) { }
    }
}