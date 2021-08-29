using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities.CV
{
    public class DevelopmentTechnology : Entity
    {
        protected DevelopmentTechnology()
        {
        }

        public DevelopmentTechnology(int id, string name, DateTime firstUse, DevelopmentTechnologyCategory category, DateTime? lastUse = null, Frequencies usageFrequency = Frequencies.Daily, Proficiencies proficiency = Proficiencies.Intermediate)
        {
            Id = id;
            Name = name;
            FirstUse = firstUse;
            DevelopmentTechnologyCategory = category;
            LastUse = lastUse;
            UsageFrequency = usageFrequency;
            Proficiency = proficiency;
        }

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
        public IEnumerable<Project> Projects { get; set; }
    }
}