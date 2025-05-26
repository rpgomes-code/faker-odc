using Bogus.Extensions.Sweden;

namespace Faker
{
    /// <summary>
    /// Sweden-related methods for the Faker class.
    /// This partial class contains all Sweden generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Sweden Methods

        /// <summary>
        /// Generates a random swedish national identity number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random swedish national identity number.</returns>
        public string GetSweden_Person_Personnummer(string language)
        {
            return CreateFaker(language).Person.Personnummer();
        }

        /// <summary>
        /// Generates a random swedish coordination number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random swedish coordination number.</returns>
        public string GetSweden_Person_Samordningsnummer(string language)
        {
            return CreateFaker(language).Person.Samordningsnummer();
        }

        #endregion
    }
}