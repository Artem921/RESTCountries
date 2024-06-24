using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Car
    {
        [JsonPropertyName("signs")]
        public string[] Signs { get; set; }

        /// <summary>
        /// The name of the side of the road that traffic drives on: left or right.
        /// </summary>
        [JsonPropertyName("side")]
        public string Side { get; set; }
    }
}
