using Bogus.Extensions.Norway;

namespace Faker
{
    /// <summary>
    /// Norway-related methods for the Faker class.
    /// This partial class contains all Norway generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Norway Methods

        /// <summary>
        /// Generates a random norwegian national identity number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random norwegian national identity number.</returns>
        public string GetNorway_Person_Fodselsnummer(string language)
        {
            return CreateFaker(language).Person.Fodselsnummer();
        }

        #endregion
    }
}