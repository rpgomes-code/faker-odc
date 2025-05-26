using Bogus.Extensions.Portugal;

namespace Faker
{
    /// <summary>
    /// Portugal-related methods for the Faker class.
    /// This partial class contains all Portugal generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Portugal Methods

        /// <summary>
        /// Generates a random Portugal número de identificação fiscal (NIF) based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Portugal número de identificação fiscal (NIF).</returns>
        public string GetPortugal_Person_Nif(string language)
        {
            return CreateFaker(language).Person.Nif();
        }

        /// <summary>
        /// Generates a random Portugal número de identificação de pessoa colectiva (NIPC) based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Portugal número de identificação de pessoa colectiva (NIPC).</returns>
        public string GetPortugal_Person_Nipc(string language)
        {
            return CreateFaker(language).Company.Nipc();
        }

        #endregion
    }
}