using System.Text.Json.Serialization;

namespace APIWithRazorViewService.Models
{
    public class Fruit
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("family")]
        public string Family { get; set; }

        [JsonPropertyName("order")]
        public string Order { get; set; }

        [JsonPropertyName("genus")]
        public string Genus { get; set; }

        [JsonPropertyName("nutritions")]
        public Nutritions Nutritions { get; set; }
    }
}
