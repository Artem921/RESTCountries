using System.Text.Json.Serialization;

namespace Domain.Model
{
    public class CapitalInfo
    {
        [JsonPropertyName("latlng")]
        private string[] Latlng { get; set; }
    }
}
