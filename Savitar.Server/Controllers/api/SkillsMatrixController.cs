using Microsoft.AspNetCore.Authorization;
using Savitar.Infrastructure.Repository.Shared;
using System.Collections.Generic;
using Savitar.Domain.Models.Entities.CV;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.api
{
    [AllowAnonymous]
    public class SkillsMatrixController : BaseApiEntityController<DevelopmentTechnology, SkillsMatrixController>
    {
        public SkillsMatrixController(IRepository<DevelopmentTechnology> repository) : base(repository)
        {
        }

        protected override IEnumerable<DevelopmentTechnology> ConfigureGetAll(IEnumerable<DevelopmentTechnology> data)
        {
            foreach (var item in data)
            {
                if (item.DevelopmentTechnologyCategory != null)
                    item.DevelopmentTechnologyCategory.Technologies = null;
            }

            return data;
        }
    }    
}
