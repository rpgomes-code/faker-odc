namespace Faker
{
    /// <summary>
    /// Company-related methods for the Faker class.
    /// This partial class contains all company generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Company Methods

        /// <summary>
        /// Generates a random company suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random company suffix.</returns>
        public string GetCompany_CompanySuffix(string language)
        {
            return CreateFaker(language).Company.CompanySuffix();
        }

        /// <summary>
        /// Generates a random company name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random company name.</returns>
        public string GetCompany_CompanyName(string language)
        {
            return CreateFaker(language).Company.CompanyName();
        }

        /// <summary>
        /// Generates a random company catch phrase based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random company catch phrase.</returns>
        public string GetCompany_CatchPhrase(string language)
        {
            return CreateFaker(language).Company.CatchPhrase();
        }

        /// <summary>
        /// Generates a random company BS based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random company BS.</returns>
        public string GetCompany_Bs(string language)
        {
            return CreateFaker(language).Company.Bs();
        }

        #endregion
    }
}