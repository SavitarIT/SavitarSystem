using Savitar.Domain.Models.CV;
using System.Collections.Generic;

namespace Savitar.Infrastructure.Repository.Shared.CV
{
    public interface ITechnologies
    {
        IEnumerable<ProjectTechnology> GetAll();
    }
}
