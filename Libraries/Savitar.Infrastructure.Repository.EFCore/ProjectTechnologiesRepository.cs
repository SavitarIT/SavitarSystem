using Microsoft.EntityFrameworkCore;
using Savitar.Infrastructure.Repository.Shared;
using System.Linq;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore
{
    internal class ProjectTechnologiesRepository : Repository<ProjectTechnology, ApplicationDbContext>, IProjectTechnologiesRepository
    {
        public ProjectTechnologiesRepository(ApplicationDbContext context) : base(context) { }

        protected override IQueryable<ProjectTechnology> ConfigureGetAll(IQueryable<ProjectTechnology> data)
        {
            return data.Include(x => x.Category);
        }

        //public override async Task<IEnumerable<ProjectTechnology>> GetAllAsync()
        //{
        //    return await Task.FromResult(ProjectTechnologiesSeedData.GetAll());
        //}
    }
}