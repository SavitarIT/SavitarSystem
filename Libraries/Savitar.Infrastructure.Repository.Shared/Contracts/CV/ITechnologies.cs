using Savitar.Domain.Models;
using System.Collections.Generic;

namespace Savitar.Infrastructure.Repository.Shared.CV
{
    public interface ITechnologies
    {
        IEnumerable<ProjectTechnology> GetAll();
    }
}
