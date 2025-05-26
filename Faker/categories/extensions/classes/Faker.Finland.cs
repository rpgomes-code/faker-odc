using Bogus.Extensions.Finland;

namespace Faker
{
    /// <summary>
    /// Finland-related methods for the Faker class.
    /// This partial class contains all Finland generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Finland Methods

        /// <summary>
        /// Generates a random Finland henkilotunnus based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Finland henkilotunnus.</returns>
        public string GetFinland_Person_Henkilotunnus(string language)
        {
            return CreateFaker(language).Person.Henkilotunnus();
        }

        #endregion
    }
}