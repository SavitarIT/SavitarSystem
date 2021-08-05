using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Server.Controllers
{
    public class SkillsMatrixController : BaseApiEntityController<ProjectTechnology, IProjectTechnologiesRepository>
    {
        public SkillsMatrixController(IProjectTechnologiesRepository repository) : base(repository) { }
    }    
}
