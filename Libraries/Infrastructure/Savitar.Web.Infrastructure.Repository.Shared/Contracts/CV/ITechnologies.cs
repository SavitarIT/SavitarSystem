using Savitar.Web.Domain.Models;
using System.Collections.Generic;

namespace Savitar.Web.Infrastructure.Repository.Contracts.CV
{
    public interface ITechnologies
    {
        IEnumerable<ProjectTechnology> GetAll();
    }
}
