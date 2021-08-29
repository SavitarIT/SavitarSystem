using Microsoft.AspNetCore.Authorization;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;
using Savitar.Domain.Models.Entities.CV;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.api
{
    [AllowAnonymous]
    public class SkillsMatrixController : BaseApiEntityController<ProjectTechnology, SkillsMatrixController>
    {
        public SkillsMatrixController(IRepository<ProjectTechnology> repository) : base(repository)
        {
        }

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
