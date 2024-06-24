using System.Text.Json.Serialization;

namespace Models.Models
{
    /// <summary>
    /// Валюты
    /// </summary>
    public class Currency
    {
        [JsonPropertyName("name")]
        public string? Name {  get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

    }
}
