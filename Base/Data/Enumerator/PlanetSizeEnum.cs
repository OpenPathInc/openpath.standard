using System.Runtime.Serialization;

namespace OpenPath.Standard.Base.Data.Enumerator {

    /// <summary>
    /// Basic set of Planet sizes.
    /// </summary>
    public enum PlanetSizeEnum {

        /// <summary>
        /// A small planet.
        /// </summary>
        [EnumMember(Value = "small")]
        Small = 1000,

        /// <summary>
        /// A medium sized planet.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium = 2000,

        /// <summary>
        /// A large panet.
        /// </summary>
        [EnumMember(Value = "large")]
        Large = 3000

    }

}
