using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Savitar.Infrastructure.Repository.Shared;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        protected override IQueryable<DevelopmentTechnology> ConfigureQuery(IQueryable<DevelopmentTechnology> data)
        {
            return data.Include(x => x.DevelopmentTechnologyCategory);
        }

        public override async Task<IList<DevelopmentTechnology>> GetAllAsync()
        {
            var result = await base.GetAllAsync();

            // Setting to null to enable us to "flatten" in a jook way, and use in the UI.
            foreach (var item in result)
            {
                if (item.DevelopmentTechnologyCategory != null)
                    item.DevelopmentTechnologyCategory.Technologies = null;
            }

            return result;
        }
    }    
}
