using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WebApi.Software.Standard.Base.Data.Enumerator;
using WebApi.Software.Utility.Repository.Abstract;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Software.Standard.Base.Data.Poco {

    /// <summary>
    /// Specialized filter adding the ability to filter Planets by Planet Size, Minimum Equatorial
    /// Diameter and Maximum Diameter.
    /// </summary>
    public class PlanetFilterPoco : FilterAbstract {

        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// Filter for planet size.
        /// </summary>
        [EnumDataType(typeof(PlanetSizeEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("planet_size")]
        public PlanetSizeEnum? PlanetSize { get; set; }

        /// <summary>
        /// Filter for minimum equatorial diameter.
        /// </summary>
        [JsonProperty("equatorial_diameter_minimum")]
        public double? EquatorialDiameterMinimum { get; set; }

        /// <summary>
        /// Filter for minimum equatorial diameter.
        /// </summary>
        [JsonProperty("equatorial_diameter_maximum")]
        public double? EquatorialDiameterMaximum { get; set; }



        // OVERRIDES
        // ====================================================================================================

        /// <summary>
        /// Creates a clone of this filter with the same parameters.
        /// </summary>
        /// <returns>PlanetFilterPoco</returns>
        public override object Clone() {

            // in order to clone this object we will convert it to a json string
            var jsonString = JsonConvert.SerializeObject(this);

            // once we have the json string we will return a new object deserialized from the json
            // string, ensure two object in two memory spaces
            return JsonConvert.DeserializeObject(jsonString, this.GetType());

        }

        /// <summary>
        /// Creates a clone of this filter changing the paging parameters to the page number.
        /// </summary>
        /// <param name="page">The page number to clone too.</param>
        /// <returns>PlanetFilterPoco</returns>
        public override object Clone(int page) {

            // in order to clone this object we will convert it to a json string
            var jsonString = JsonConvert.SerializeObject(this);

            // once we have the json string we will return a new object deserialized from the json
            // string, ensure two object in two memory spaces
            var clone = JsonConvert.DeserializeObject<PlanetFilterPoco>(jsonString);

            // finally before returning the object let change the page number
            clone.Page += page;

            return clone;

        }

    }

}
