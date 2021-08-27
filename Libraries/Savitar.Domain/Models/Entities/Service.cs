using System.ComponentModel.DataAnnotations;

namespace Savitar.Domain.Models.Entities
{
    public class Service : Entity
    {
        [Required, StringLength(150, MinimumLength = 3)]
        public string Title { get; init; }       
        public string Description { get; init; }

        protected Service() { }

        public Service(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }    
    }
}
