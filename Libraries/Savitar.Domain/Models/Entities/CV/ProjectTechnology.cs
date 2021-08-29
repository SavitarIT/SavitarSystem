using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities.CV
{
    public class ProjectTechnology : Entity
    {
        protected ProjectTechnology()
        {
        }

        public ProjectTechnology(int id, string name, DateTime firstUse, ProjectTechnologyCategory category, DateTime? lastUse = null, Frequencies usageFrequency = Frequencies.Daily, Proficiencies proficiency = Proficiencies.Intermediate)
        {
            Id = id;
            Name = name;
            FirstUse = firstUse;
            Category = category;
            LastUse = lastUse;
            UsageFrequency = usageFrequency;
            Proficiency = proficiency;
        }

        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required]
        public ProjectTechnologyCategory Category { get; set; }
        public ICollection<Project> Projects { get; set; }

        [Required]
        public DateTime FirstUse { get; set; }
        public DateTime? LastUse { get; set; }
        [Required]
        public Frequencies UsageFrequency { get; set; }
        [Required]
        public Proficiencies Proficiency { get; set; }
    }
}