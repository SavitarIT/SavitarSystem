using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities.CV
{
    public class DevelopmentTechnology : Entity
    {
        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required]
        public DevelopmentTechnologyCategory DevelopmentTechnologyCategory { get; set; }

        [Required]
        public DateTime FirstUse { get; set; }
        public DateTime? LastUse { get; set; }
        [Required]
        public Frequencies UsageFrequency { get; set; }
        [Required]
        public Proficiencies Proficiency { get; set; }
        public IEnumerable<PortfolioProject> PortfolioProjects { get; set; }
    }
}