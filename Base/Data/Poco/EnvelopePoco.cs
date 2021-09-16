using Newtonsoft.Json;
using WebApi.Software.Utility.Repository.Interface;
using System;

namespace WebApi.Software.Standard.Base.Data.Poco {

    /// <summary>
    /// A structure for returning standardized data packets to a requesting service.
    /// </summary>
    /// <typeparam name="T">The data type outside the standardized data returned.</typeparam>
    public class EnvelopePoco<T> where T : class {

        // PROPERTIES
        // ====================================================================================================

        /// <summary>
        /// The name of the company supporting this API.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The name of this API.
        /// </summary>
        [JsonProperty("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// The copyright of this API.
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// The version of this API.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// The data model or list returned with or without children depending on the service
        /// requested.
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; }

        /// <summary>
        /// Filter applied to REST query.
        /// </summary>
        [JsonProperty("filter")]
        public IFilter Filter { get; set; }

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

        /// <summary>
        /// Records the response Timestamp of this envelope in UTC.
        /// </summary>
        [JsonProperty("utc_timestamp")]
        public DateTime UtcTimestamp { get; set; }

        /// <summary>
        /// Returns the response from this request, including errors if any.
        /// </summary>
        [JsonProperty("response")]
        public EnvelopeResponsePaco Response { get; set; }

    }

}
