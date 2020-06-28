using System.Collections.Generic;
using System.Dynamic;

namespace Savitar.Web.Shared.Models
{
    public class Project
    {
        public Project() {}

        public Project(string name)
        {
            Name = name;
        }

        public Client Client { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public IEnumerable<ProjectResponsibility> Responsibilities { get; set; }
        public IEnumerable<ProjectTechnology> TechStack { get; set; }
    }
}
