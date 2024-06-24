using System.Text.Json.Serialization;

namespace Models.Models
{
    /// <summary>
    /// Наименование страны
    /// </summary>
    public class CountryName 
    {
        /// <summary>
        /// Наименование страны
        /// </summary>
        [JsonPropertyName("common")]
        public string? Common { get; set; }

        /// <summary>
        /// Наименование страны
        /// </summary>

        [JsonPropertyName("official")]
        public string? Official { get; set; } 


    }
}
