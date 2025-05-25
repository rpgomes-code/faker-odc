namespace Faker
{
    /// <summary>
    /// Name-related methods for the Faker class.
    /// This partial class contains all name generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Name Methods

        /// <summary>
        /// Generates a random first name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random first name.</returns>
        public string GetName_FirstName(string language)
        {
            return CreateFaker(language).Name.FirstName();
        }

        /// <summary>
        /// Generates a random last name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random last name.</returns>
        public string GetName_LastName(string language)
        {
            return CreateFaker(language).Name.LastName();
        }

        /// <summary>
        /// Generates a random full name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random full name.</returns>
        public string GetName_FullName(string language)
        {
            return CreateFaker(language).Name.FullName();
        }

        /// <summary>
        /// Generates a random name prefix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random name prefix.</returns>
        public string GetName_NamePrefix(string language)
        {
            return CreateFaker(language).Name.Prefix();
        }

        /// <summary>
        /// Generates a random name suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random name suffix.</returns>
        public string GetName_NameSuffix(string language)
        {
            return CreateFaker(language).Name.Suffix();
        }

        /// <summary>
        /// Generates a random full name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random full name.</returns>
        public string GetName_FindName(string language)
        {
            return CreateFaker(language).Name.FindName();
        }

        /// <summary>
        /// Generates a random job title based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job title.</returns>
        public string GetName_JobTitle(string language)
        {
            return CreateFaker(language).Name.JobTitle();
        }

        /// <summary>
        /// Generates a random job descriptor based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job descriptor.</returns>
        public string GetName_JobDescriptor(string language)
        {
            return CreateFaker(language).Name.JobDescriptor();
        }

        /// <summary>
        /// Generates a random job area based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job area.</returns>
        public string GetName_JobArea(string language)
        {
            return CreateFaker(language).Name.JobArea();
        }

        /// <summary>
        /// Generates a random job type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job type.</returns>
        public string GetName_JobType(string language)
        {
            return CreateFaker(language).Name.JobType();
        }

        #endregion
    }
}