using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;

namespace Savitar.Server.Controllers
{
    public class SkillsMatrixController : BaseApiEntityController<ProjectTechnology, IProjectTechnologiesRepository>
    {
        public SkillsMatrixController(IProjectTechnologiesRepository repository) : base(repository) { }

        protected override IEnumerable<ProjectTechnology> ConfigureGetAll(IEnumerable<ProjectTechnology> data)
        {
            foreach (var item in data)
            {
                if (item.Category != null)
                    item.Category.Technologies = null;
            }

            return data;
        }        
    }    
}
