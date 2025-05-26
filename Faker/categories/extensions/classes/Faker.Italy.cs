using Bogus.Extensions.Italy;

namespace Faker
{
    /// <summary>
    /// Italy-related methods for the Faker class.
    /// This partial class contains all Italy generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Italy Methods

        /// <summary>
        /// Generates a random Italy codice fiscale based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Italy codice fiscale.</returns>
        public string GetItaly_Person_CodiceFiscale(string language)
        {
            return CreateFaker(language).Person.CodiceFiscale();
        }

        #endregion
    }
}