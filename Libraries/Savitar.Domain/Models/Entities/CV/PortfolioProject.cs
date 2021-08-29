using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities.CV
{
    public class PortfolioProject : Entity
    {
        [Required]
        public PortfolioClient PortfolioClient { get; set; }

        [Required, StringLength(200)]        
        public string Name { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        [StringLength(450)]
        public string Url { get; set; }
        public IEnumerable<DevelopmentTechnology> DevelopmentTechnologies { get; set; }
    }
}
