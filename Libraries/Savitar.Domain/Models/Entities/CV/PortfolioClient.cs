using System.Collections.Generic;

namespace Savitar.Domain.Models.Entities.CV
{
    public class PortfolioClient : Entity
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public ICollection<PortfolioProject> PortfolioProjects { get; set; }
    }
}