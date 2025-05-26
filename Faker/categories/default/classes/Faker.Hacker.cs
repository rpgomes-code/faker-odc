namespace Faker
{
    /// <summary>
    /// Hacker-related methods for the Faker class.
    /// This partial class contains all hacker generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Hacker Methods

        /// <summary>
        /// Generates a random hacker abbreviation based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker abbreviation.</returns>
        public string GetHacker_Abbreviation(string language)
        {
            return CreateFaker(language).Hacker.Abbreviation();
        }

        /// <summary>
        /// Generates a random hacker adjective based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker adjective.</returns>
        public string GetHacker_Adjective(string language)
        {
            return CreateFaker(language).Hacker.Adjective();
        }

        /// <summary>
        /// Generates a random hacker noun based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker noun.</returns>
        public string GetHacker_Noun(string language)
        {
            return CreateFaker(language).Hacker.Noun();
        }

        /// <summary>
        /// Generates a random hacker verb based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker verb.</returns>
        public string GetHacker_Verb(string language)
        {
            return CreateFaker(language).Hacker.Verb();
        }

        /// <summary>
        /// Generates a random hacker verb fnishing with 'ing' based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker verb fnishing with 'ing'.</returns>
        public string GetHacker_IngVerb(string language)
        {
            return CreateFaker(language).Hacker.IngVerb();
        }

        /// <summary>
        /// Generates a random hacker phrase based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker phrase.</returns>
        public string GetHacker_Phrase(string language)
        {
            return CreateFaker(language).Hacker.Phrase();
        }

        #endregion
    }
}