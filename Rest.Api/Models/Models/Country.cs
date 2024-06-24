using System.Text.Json.Serialization;

namespace Models.Models
{
    /// <summary>
    /// Страна
    /// </summary>
    public class Country
    {

        /// <summary>
        /// Наименование страны
        /// </summary>
        [JsonPropertyName("name")]
        public CountryName Name { get; set; }

        /// <summary>
        /// Столиза страны
        /// </summary>
        [JsonPropertyName("capital")]
        public string[]? Capital { get; set; }

        /// <summary>
        /// Население
        /// </summary>

        [JsonPropertyName("population")]
        public int Population { get; set; }

        /// <summary>
        /// Демографияеский регион
        /// </summary>

        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// Демографияеский субрегион
        /// </summary>

        [JsonPropertyName("subregion")]
        public string SubRegion {  get; set; }

        /// <summary>
        /// Статус присвоения
        /// </summary>

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///Автомобильные отличия
        /// </summary>

        [JsonPropertyName("car")]
        public Car? Car { get; set; }

        /// <summary>
        ///Список официальных языков
        /// </summary>

        [JsonPropertyName("languages")]
        public Dictionary<string, string>? Languages { get; set; }

        /// <summary>
        /// Валюты
        /// </summary>

        [JsonPropertyName("currencies")]
        public Dictionary<string, Currency>? Currencies { get; set; }

        public Country() { }
        public Country(CountryName name, 
                       string[]? capital,
                       int population, 
                       string region,
                       string subRegion, 
                       string? status, 
                       Car? car, 
                       Dictionary<string, string>? languages,
                       Dictionary<string, Currency>? currencies)
        {
            Name = name;
            Capital = capital;
            Population = population;
            Region = region;
            SubRegion = subRegion;
            Status = status;
            Car = car;
            Languages = languages;
            Currencies = currencies;
        }

    }
}
