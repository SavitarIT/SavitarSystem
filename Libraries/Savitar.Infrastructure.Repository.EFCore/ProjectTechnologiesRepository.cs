using Microsoft.EntityFrameworkCore;
using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.SeedData;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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