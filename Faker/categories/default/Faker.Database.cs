namespace Faker
{
    /// <summary>
    /// Database-related methods for the Faker class.
    /// This partial class contains all database generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Database Methods

        /// <summary>
        /// Generates a random database column based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random database column.</returns>
        public string GetDatabase_Column(string language)
        {
            return CreateFaker(language).Database.Column();
        }

        /// <summary>
        /// Generates a random database type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random database type.</returns>
        public string GetDatabase_Type(string language)
        {
            return CreateFaker(language).Database.Type();
        }

        /// <summary>
        /// Generates a random database collation based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random database collation.</returns>
        public string GetDatabase_Collation(string language)
        {
            return CreateFaker(language).Database.Collation();
        }

        /// <summary>
        /// Generates a random database engine based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random database engine.</returns>
        public string GetDatabase_Engine(string language)
        {
            return CreateFaker(language).Database.Engine();
        }

        #endregion
    }
}