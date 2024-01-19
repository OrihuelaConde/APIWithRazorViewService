using System.Text.Json.Serialization;

namespace APIWithRazorViewService.Models
{
    public class Nutritions
    {
        [JsonPropertyName("calories")]
        public int Calories { get; set; }

        [JsonPropertyName("fat")]
        public double Fat { get; set; }

        [JsonPropertyName("sugar")]
        public double Sugar { get; set; }

        [JsonPropertyName("carbohydrates")]
        public double Carbohydrates { get; set; }

        [JsonPropertyName("protein")]
        public double Protein { get; set; }
    }
}
