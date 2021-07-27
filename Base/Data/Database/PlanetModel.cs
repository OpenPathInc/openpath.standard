using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenPath.Standard.Base.Data.Database {

    [Table("Planets")]
    public class PlanetModel {

        [Key, Required]
        [JsonProperty("id")]
        public long Id { get; set; }

        [Required, MaxLength(64)]
        [JsonProperty("key")]
        public string Key { get; set; }

        [Required, MaxLength(64)]
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("equatorial_diameter")]
        public double EquatorialDiameter { get; set; }
        
        [JsonProperty("equatorial_bulge")]
        public double EquatorialBulge { get; set; }

        [JsonProperty("polar_diameter")]
        public double PolarDiameter { get; set; }

        [JsonProperty("flattening_ratio")]
        public double FlatteningRatio { get; set;  }

        [JsonProperty("rotation_period")]
        public double RotationPeriod { get; set; }

        [JsonProperty("density")]
        public double Density { get; set; }

        [JsonProperty("f")]
        public double F { get; set; }

        [JsonProperty("deviation_from_f")]
        public int DeviationFromF { get; set; }

    }

}
