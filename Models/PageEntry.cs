using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace SABlues.Models
{
    public class PageEntry
    {
        public string Id { get; set; }
        public string Title { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<PageEntry>(this,
            new JsonSerializerOptions
            {
                //TODO: Makt it accept special charectors : Swedish/Norsk
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            });

    }
}
