using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Savitar.Infrastructure.Repository.EFCore.SeedData;

namespace Savitar.Infrastructure.Repository.EFCore
{
    internal class ProjectsRepository : Repository<Project, ApplicationDbContext>, IProjectsRepository
    {
        public ProjectsRepository(ApplicationDbContext context) : base(context) { }

        public override async Task<IEnumerable<Project>> GetAllAsync()
        {
            var result = ClientsAndProjectsSeedData.GetAll()
                .Select(x => x.Projects)
                .SelectMany(x => x)
                .OrderBy(x => x.Name).ToList();

            return await Task.FromResult(result.ToArray());
        }
    }
}