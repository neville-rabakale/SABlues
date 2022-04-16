using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SABlues.Models
{
    public class Puppies
    {
        public string Id { get; set; }
        public string Group { get; set; }
        public string BirthDate { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("birthName")]
        public string BirthName { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Puppies>(this);
    }
}
