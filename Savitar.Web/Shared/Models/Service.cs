namespace Savitar.Web.Shared.Models
{
    public class Service
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
