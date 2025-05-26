using Bogus.Extensions.UnitedStates;

namespace Faker
{
    /// <summary>
    /// United States-related methods for the Faker class.
    /// This partial class contains all United States generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region UnitedStates Methods

        /// <summary>
        /// Generates a random United States social security number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random United States social security number.</returns>
        public string GetUnitedStates_Person_Ssn(string language)
        {
            return CreateFaker(language).Person.Ssn();
        }

        /// <summary>
        /// Generates a random United States employer identification number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random United States employer identification number.</returns>
        public string GetUnitedStates_Company_Ein(string language)
        {
            return CreateFaker(language).Company.Ein();
        }

        #endregion
    }
}