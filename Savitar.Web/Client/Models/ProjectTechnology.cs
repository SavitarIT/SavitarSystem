using System;

namespace Savitar.Web.Client.Models
{
    public class ProjectTechnology : Entity
    {
        public ProjectTechnology()
        {
        }

        public ProjectTechnology(string name, DateTime firstUse, ProjectTechnologyCategory category = null, DateTime? lastUse = null, Frequencies usageFrequency = Frequencies.Daily, Proficiencies proficiency = Proficiencies.Intermediate)
        {
            Name = name;
            FirstUse = firstUse;
            Category = category;
            LastUse = lastUse;
            UsageFrequency = usageFrequency;
            Proficiency = proficiency;
        }

        public string Name { get; set; }
        public ProjectTechnologyCategory Category { get; set; }
        public DateTime FirstUse { get; set; }
        public DateTime? LastUse { get; set; }
        public Frequencies UsageFrequency { get; set; }
        public Proficiencies Proficiency { get; set; }
    }
}