using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities.CV
{
    public class DevelopmentTechnologyCategory : Entity
    {
        [Required, StringLength(200)]
        public string Name { get; init; }

        public List<DevelopmentTechnology> Technologies { get; set; }
    }
}