using Bogus.Extensions.Denmark;

namespace Faker
{
    /// <summary>
    /// Denmark-related methods for the Faker class.
    /// This partial class contains all Denmark generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Denmark Methods

        /// <summary>
        /// Generates a random Denmark personal identification number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Denmark personal identification number.</returns>
        public string GetDenmark_Person_Cpr(string language)
        {
            return CreateFaker(language).Person.Cpr();
        }

        #endregion
    }
}