namespace OpenPath.Utility.Repository.Helper {

    /// <summary>
    /// A static helper class to help with data objects.
    /// </summary>
    public static class DataHelper {

        // TODO: Create a better Compare and Replace that can take a whole object using reflections
        // and iterate through each property to compare.

        /// <summary>
        /// Looks at an existing object and determines if it is different, if it is it replaces the
        /// existing object with the new object.
        /// </summary>
        /// <typeparam name="T">The type of object to compare.</typeparam>
        /// <param name="existingObject">The current existing object to compare against.</param>
        /// <param name="newObject">The new object that might have changes.</param>
        /// <returns></returns>
        public static T CompareAndReplace<T>(object existingObject, object newObject) {

            if (existingObject == newObject) return (T)existingObject;
            else return (T)newObject;

        }

    }

}
