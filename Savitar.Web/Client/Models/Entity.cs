using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Savitar.Web.Client.Models
{
    public abstract class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}