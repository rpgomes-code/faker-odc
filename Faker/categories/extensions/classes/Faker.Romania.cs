using Bogus.Extensions.Romania;

namespace Faker
{
    /// <summary>
    /// Romania-related methods for the Faker class.
    /// This partial class contains all Romania generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Romania Methods

        /// <summary>
        /// Generates a random romanian personal identification number (CNP) based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random romanian personal identification number (CNP).</returns>
        public string GetRomania_Person_Cnp(string language)
        {
            return CreateFaker(language).Person.Cnp();
        }

        #endregion
    }
}