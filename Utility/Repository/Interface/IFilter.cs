namespace OpenPath.Utility.Repository.Interface {

    /// <summary>
    /// A generic filter to apply to entities.
    /// </summary>
    public interface IFilter {

        /// <summary>
        /// The page number to return on the filter.
        /// </summary>
        int Page { get; set; }

        /// <summary>
        /// The amount or results to return on the filter.
        /// </summary>
        int Limit { get; set; } 

    }

}
