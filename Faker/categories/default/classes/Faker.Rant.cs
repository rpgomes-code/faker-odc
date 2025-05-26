namespace Faker
{
    /// <summary>
    /// Rant-related methods for the Faker class.
    /// This partial class contains all rant generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Rant Methods

        /// <summary>
        /// Generates a random review based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random review.</returns>
        public string GetRant_Review(string language)
        {
            return CreateFaker(language).Rant.Review();
        }

        /// <summary>
        /// Generates a random reviews based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random reviews.</returns>
        public string[] GetRant_Reviews(string language)
        {
            return CreateFaker(language).Rant.Reviews();
        }

        #endregion
    }
}