using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Savitar.Domain.Shared;

namespace Savitar.Domain.Models.Entities
{
    public abstract class Entity : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}