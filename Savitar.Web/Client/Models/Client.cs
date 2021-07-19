using System.Collections.Generic;

namespace Savitar.Web.Client.Models
{
    public class Client
    {
        public Client() {}

        public Client(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Url { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}