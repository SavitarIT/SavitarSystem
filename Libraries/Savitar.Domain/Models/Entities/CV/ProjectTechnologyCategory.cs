using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities.CV
{
    public class ProjectTechnologyCategory : Entity
    {
        [Required, StringLength(200)]
        public string Name { get; init; }

        public List<ProjectTechnology> Technologies { get; set; }
    }
}