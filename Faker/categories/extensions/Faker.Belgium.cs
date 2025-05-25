using Bogus.Extensions.Belgium;

namespace Faker
{
    /// <summary>
    /// Belgium-related methods for the Faker class.
    /// This partial class contains all Belgium generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Belgium Methods

        /// <summary>
        /// Generates a random Belgium national number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Belgium national number.</returns>
        public string GetBelgium_Person_NationalNumber(string language)
        {
            return CreateFaker(language).Person.NationalNumber();
        }

        #endregion
    }
}