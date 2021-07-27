using System.Runtime.Serialization;

namespace OpenPath.Standard.Base.Data.Enumerator {

    public enum PlanetSizeEnum {

        [EnumMember(Value = "small")]
        Small,

        [EnumMember(Value = "medium")]
        Medium,

        [EnumMember(Value = "large")]
        Large

    }

}
