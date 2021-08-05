using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.SeedData;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Savitar.Infrastructure.Repository.EFCore
{
    internal class ProjectTechnologiesRepository : Repository<ProjectTechnology, ApplicationDbContext>, IProjectTechnologiesRepository
    {
        public ProjectTechnologiesRepository(ApplicationDbContext context) : base(context) { }

        public override async Task<IEnumerable<ProjectTechnology>> GetAllAsync()
        {
            return await Task.FromResult(ProjectTechnologiesSeedData.GetAll());
        }
    }
}