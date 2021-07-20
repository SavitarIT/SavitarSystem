namespace Savitar.Web.Server.Models
{
    public class Service : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Service() { }
        public Service(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
