using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;
using Savitar.Server.Controllers.api.Base;

namespace Savitar.Server.Controllers.api
{
    [AllowAnonymous]
    public class SkillsMatrixController : BaseApiEntityController<ProjectTechnology, IProjectTechnologiesRepository, SkillsMatrixController>
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
