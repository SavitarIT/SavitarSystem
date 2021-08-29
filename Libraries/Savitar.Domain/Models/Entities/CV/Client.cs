using System.Collections.Generic;

namespace Savitar.Domain.Models.Entities.CV
{
    public class Client : Entity
    {
        public Client() {}

        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
        public string Url { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}