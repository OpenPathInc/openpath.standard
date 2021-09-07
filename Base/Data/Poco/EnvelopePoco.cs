using Newtonsoft.Json;
using System;

namespace OpenPath.Standard.Base.Data.Poco {

    /// <summary>
    /// A structure for returning standardized data packets to a requesting service.
    /// </summary>
    /// <typeparam name="T">The data type outside the standardized data returned.</typeparam>
    public class EnvelopePoco<T> where T : class {

        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// The data model or list returned with or without children depending on the service
        /// requested.
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        /// <summary>
        /// If only a limited set of data was returned and more data exists, the reference of the
        /// next set of data will be set here. Otherwise, if there is no more data, this value will
        /// be null.
        /// </summary>
        [JsonProperty("next_page")]
        public Uri NextPage { get; set; }

        /// <summary>
        /// If the returned data is in a different page than the first page of data, the reference
        /// of the last set of data will be set here, if this is the first page, then this valud
        /// will be null.
        /// </summary>
        [JsonProperty("last_page")]
        public Uri LastPage { get; set; }

        /// <summary>
        /// This is the reference to the current page of data.
        /// </summary>
        [JsonProperty("current_page")]
        public Uri CurrentPage { get; set; }

    }

}
