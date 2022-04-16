using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SABlues.Models
{
    public class PuppyLitters
    {
        [Key]
        public int Id { get; set; }
        public string LitterName { get; set; }
        [JsonPropertyName("birthDate")]
        public string BirthDate { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Heritage { get; set; }
        public string Description { get; set; }

        //Puppy ID from Puppies
        public int PuppiesId { get; set; }
        [ForeignKey("PuppiesID")]
        public Puppies Puppies { get; set; }
       
    }
}
