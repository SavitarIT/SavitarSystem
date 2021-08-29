using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities.CV
{
    public class Project : Entity
    {
        public Project() {}

        public Project(int id)
        {
            Id = id;
        }

        public Project(int id, string name)
        {
            Id = id;
            Name = name;
        }

        [Required]
        public Client Client { get; set; }

        [Required, StringLength(200)]        
        public string Name { get; set; }
        [StringLength(4000)]
        public string Description { get; set; }
        [StringLength(200)]
        public string Url { get; set; }
        public IEnumerable<ProjectResponsibility> Responsibilities { get; set; }
        public IEnumerable<ProjectTechnology> TechStack { get; set; }
    }
}
