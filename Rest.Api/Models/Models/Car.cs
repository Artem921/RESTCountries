using System.Text.Json.Serialization;

namespace Models.Models
{
    public class Car
    {
        [JsonPropertyName("signs")]
        public string[]? Signs { get; set; }

        [JsonPropertyName("side")]
        public string? Side { get; set; }
    }
}
