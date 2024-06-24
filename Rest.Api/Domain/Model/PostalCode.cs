using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class PostalCode
    {
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// Regex pattern for the postal code.
        /// </summary>
        [JsonPropertyName("regex")]
        public string Regex { get; set; }
    }
}
