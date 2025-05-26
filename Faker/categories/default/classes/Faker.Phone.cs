namespace Faker
{
    /// <summary>
    /// Phone-related methods for the Faker class.
    /// This partial class contains all phone generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Phone Methods

        /// <summary>
        /// Generates a random phone number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random phone number.</returns>
        public string GetPhone_PhoneNumber(string language)
        {
            return CreateFaker(language).Phone.PhoneNumber();
        }

        /// <summary>
        /// Generates a random phone number formated based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random phone number formated.</returns>
        public string GetPhone_PhoneNumberFormat(string language)
        {
            return CreateFaker(language).Phone.PhoneNumberFormat();
        }

        #endregion
    }
}