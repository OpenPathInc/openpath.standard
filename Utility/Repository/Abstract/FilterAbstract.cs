using System;
using Newtonsoft.Json;
using WebApi.Software.Utility.Repository.Interface;

namespace WebApi.Software.Utility.Repository.Abstract {

    /// <summary>
    /// A generic filter for database models.
    /// </summary>
    public abstract class FilterAbstract : IFilter, ICloneable {

        /// <summary>
        /// The page number to return on the filter.
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// The amount or results to return on the filter.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; } = 20; 
  
        /// <summary>
        /// Clones the existing filter in a new memory space.
        /// </summary>
        /// <returns>A new copy of the filter.</returns>
        public abstract object Clone();

        /// <summary>
        /// Returns a clone +/- the page number of the original filter.
        /// </summary>
        /// <param name="page">The amount you want to up or down the filter page.</param>
        /// <returns>The filter +/- the page number.</returns>
        public abstract object Clone(int page);

    }

}
