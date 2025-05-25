using Bogus.Extensions.Canada;

namespace Faker
{
    /// <summary>
    /// Canada-related methods for the Faker class.
    /// This partial class contains all Canada generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Canada Methods

        /// <summary>
        /// Generates a random Canada social insurance number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Canada social insurance number.</returns>
        public string GetCanada_Person_Sin(string language)
        {
            return CreateFaker(language).Person.Sin();
        }

        #endregion
    }
}