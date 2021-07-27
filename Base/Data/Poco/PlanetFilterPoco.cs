using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenPath.Standard.Base.Data.Enumerator;
using OpenPath.Utility.Repository.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OpenPath.Standard.Base.Data.Poco {

    public class PlanetFilterPoco : FilterAbstract {

        [EnumDataType(typeof(PlanetSizeEnum))]
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("planet_size")]
        public PlanetSizeEnum? PlanetSize { get; set; }

        [JsonProperty("equatorial_diameter_minimum")]
        public double? EquatorialDiameterMinimum { get; set; }

        [JsonProperty("equatorial_diameter_maximum")]
        public double? EquatorialDiameterMaximum { get; set; }

        public override object Clone() {

            var jsonString = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject(jsonString, this.GetType());

        }

        public override object Clone(int page) {

            var jsonString = JsonConvert.SerializeObject(this);
            var clone = JsonConvert.DeserializeObject<PlanetFilterPoco>(jsonString);

            clone.Page += page;

            return clone;

        }

    }

}
