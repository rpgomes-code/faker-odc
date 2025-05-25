using Bogus.Extensions.Poland;

namespace Faker
{
    /// <summary>
    /// Poland-related methods for the Faker class.
    /// This partial class contains all NoPolandrway generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Poland Methods

        /// <summary>
        /// Generates a random number of powszechny elektroniczny system ewidencji ludności (PESEL) based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random number of powszechny elektroniczny system ewidencji ludności (PESEL).</returns>
        public string GetPoland_Person_Pesel(string language)
        {
            return CreateFaker(language).Person.Pesel();
        }

        /// <summary>
        /// Generates a random numer identyfikacji podatkowej (NIP) based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random numer identyfikacji podatkowej (NIP).</returns>
        public string GetPoland_Company_Nip(string language)
        {
            return CreateFaker(language).Company.Nip();
        }

        /// <summary>
        /// Generates a random number of rejestr gospodarki narodowej (REGON) based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random number of rejestr gospodarki narodowej (REGON).</returns>
        public string GetPoland_Company_Regon(string language)
        {
            return CreateFaker(language).Company.Regon();
        }

        #endregion
    }
}