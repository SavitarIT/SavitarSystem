using Savitar.Domain.Models;
using System.Collections.Generic;

namespace Savitar.Infrastructure.Repository.Contracts.CV
{
    public interface IServices
    {
        IEnumerable<Service> GetAll();
    }
}
