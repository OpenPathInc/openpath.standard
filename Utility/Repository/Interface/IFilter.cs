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

        /// <summary>
        /// Clones the existing filter in a new memory space.
        /// </summary>
        /// <returns>A new copy of the filter.</returns>
        object Clone();

        /// <summary>
        /// Returns a clone +/- the page number of the original filter.
        /// </summary>
        /// <param name="page">The amount you want to up or down the filter page.</param>
        /// <returns>The filter +/- the page number.</returns>
        object Clone(int page);

    }

}
