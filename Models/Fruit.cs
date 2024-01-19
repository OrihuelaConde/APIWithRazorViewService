using System.Text.Json.Serialization;

namespace APIWithRazorViewService.Models
{
    public class Fruit
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("family")]
        public string Family { get; set; } = null!;

        [JsonPropertyName("order")]
        public string Order { get; set; } = null!;

        [JsonPropertyName("genus")]
        public string Genus { get; set; } = null!;

        [JsonPropertyName("nutritions")]
        public Nutritions Nutritions { get; set; } = null!;
    }
}
