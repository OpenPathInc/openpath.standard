using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenPath.Standard.Base.Data.Database {


    /// <summary>
    /// Represents a planet in our solar system.
    /// </summary>
    [Table("Planets")]
    public class PlanetModel {

        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// A unique planet ID in the database.
        /// </summary>
        [Key, Required]
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// A unique text key that has a 1 to 1 relationship to the planet ID based off the name of
        /// the planet.
        /// </summary>
        [Required, MaxLength(64)]
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// The english name for this planet.
        /// </summary>
        [Required, MaxLength(64)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The diameter of the planet at its equator.
        /// </summary>
        [JsonProperty("equatorial_diameter")]
        public double EquatorialDiameter { get; set; }

        /// <summary>
        /// The equatorial bulge is a difference between the equatorial and polar diameters of a
        /// planet, due to the centrifugal force exerted by the rotation about the body's axis.
        /// A rotating body tends to form an oblate spheroid rather than a sphere.
        /// </summary>
        [JsonProperty("equatorial_bulge")]
        public double EquatorialBulge { get; set; }

        /// <summary>
        /// The diameter of a planet measured from pole to pole.
        /// </summary>
        [JsonProperty("polar_diameter")]
        public double PolarDiameter { get; set; }

        /// <summary>
        /// The flattening ratio is a measure of how much an oblate spheroid differs from a sphere.
        /// The flattening equals the ratio of the semimajor axis minus the semiminor axis to the
        /// semimajor axis.
        /// </summary>
        [JsonProperty("flattening_ratio")]
        public double FlatteningRatio { get; set; }

        /// <summary>
        /// The rotation period of a celestial object (e.g., star, gas giant, planet, moon,
        /// asteroid) is as its sidereal rotation period the time that the object takes to complete
        /// a single revolution around its axis of rotation relative to the background stars,
        /// measured in sidereal time. This type of rotation period differs from the object's
        /// synodic rotation period (a solar day), measured in solar time, which may differ by a
        /// fractional or multiple rotation to accommodate the portion of the object's orbital
        /// period during one day.
        /// </summary>
        [JsonProperty("rotation_period")]
        public double RotationPeriod { get; set; }

        /// <summary>
        /// The planet density is defined as the ratio of the mass of a planet to the volume of
        /// space the planet takes up.
        /// </summary>
        [JsonProperty("density")]
        public double Density { get; set; }

        /// <summary>
        /// f = Flattening which is a measure of the compression of a circle or sphere along a
        /// diameter to form an ellipse or an ellipsoid of revolution (spheroid) respectively.
        /// </summary>
        [JsonProperty("f")]
        public double F { get; set; }

        /// <summary>
        /// The deviation from Flattenting.
        /// </summary>
        [JsonProperty("deviation_from_f")]
        public int DeviationFromF { get; set; }

    }

}
