using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Maps
    { /// <summary>
      /// Google Maps location URL.
      /// </summary>
        [JsonPropertyName("googleMaps")]
        public string GoogleMaps { get; set; }

        /// <summary>
        /// Open Street Maps location URL.
        /// </summary>
        [JsonPropertyName("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }
}
