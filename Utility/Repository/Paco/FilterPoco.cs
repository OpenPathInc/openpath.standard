using Newtonsoft.Json;
using OpenPath.Utility.Repository.Abstract;

namespace OpenPath.Utility.Repository.Poco {

    /// <summary>
    /// Specialized filter adding the ability to filter Planets by Planet Size, Minimum Equatorial
    /// Diameter and Maximum Diameter.
    /// </summary>
    public class FilterPoco : FilterAbstract {

        // OVERRIDES
        // ====================================================================================================

        /// <summary>
        /// Creates a clone of this filter with the same parameters.
        /// </summary>
        /// <returns>PlanetFilterPoco</returns>
        public override object Clone() {

            var jsonString = JsonConvert.SerializeObject(this);  
            return JsonConvert.DeserializeObject(jsonString,this.GetType()); 

        }

        /// <summary>
        /// Creates a clone of this filter changing the paging parameters to the page number.
        /// </summary>
        /// <param name="page">The page number to clone too.</param>
        /// <returns>PlanetFilterPoco</returns>
        public override object Clone(int page) {

            var jsonString = JsonConvert.SerializeObject(this);
            var clone = JsonConvert.DeserializeObject<FilterPoco>(jsonString);

            clone.Page += page;

            return clone;

        }

    }

}
