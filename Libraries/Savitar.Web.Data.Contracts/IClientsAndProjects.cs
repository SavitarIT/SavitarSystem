using Savitar.Web.Models;
using System.Collections.Generic;

namespace Savitar.Web.Data.Contracts
{
    public interface IClientsAndProjects
    {
        IEnumerable<Client> GetAll();
    }
}
