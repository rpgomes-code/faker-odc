namespace Faker
{
    /// <summary>
    /// Lorem-related methods for the Faker class.
    /// This partial class contains all lorem generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Lorem Methods

        /// <summary>
        /// Generates a random lorem word based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem word.</returns>
        public string GetLorem_Word(string language)
        {
            return CreateFaker(language).Lorem.Word();
        }

        /// <summary>
        /// Generates a random lorem words based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem words.</returns>
        public string[] GetLorem_Words(string language)
        {
            return CreateFaker(language).Lorem.Words();
        }

        /// <summary>
        /// Generates a random lorem letter based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem letter.</returns>
        public string GetLorem_Letter(string language)
        {
            return CreateFaker(language).Lorem.Letter();
        }

        /// <summary>
        /// Generates a random lorem sentence based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem sentence.</returns>
        public string GetLorem_Sentence(string language)
        {
            return CreateFaker(language).Lorem.Sentence();
        }

        /// <summary>
        /// Generates a random lorem sentences based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem sentences.</returns>
        public string GetLorem_Sentences(string language)
        {
            return CreateFaker(language).Lorem.Sentences();
        }

        /// <summary>
        /// Generates a random lorem paragraph based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem paragraph.</returns>
        public string GetLorem_Paragraph(string language)
        {
            return CreateFaker(language).Lorem.Paragraph();
        }

        /// <summary>
        /// Generates a random lorem paragraphs based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem paragraphs.</returns>
        public string GetLorem_Paragraphs(string language)
        {
            return CreateFaker(language).Lorem.Paragraphs();
        }

        /// <summary>
        /// Generates a random lorem text based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem text.</returns>
        public string GetLorem_Text(string language)
        {
            return CreateFaker(language).Lorem.Text();
        }

        /// <summary>
        /// Generates a random lorem lines based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem lines.</returns>
        public string GetLorem_Lines(string language)
        {
            return CreateFaker(language).Lorem.Lines();
        }

        /// <summary>
        /// Generates a random lorem slug based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem slug.</returns>
        public string GetLorem_Slug(string language)
        {
            return CreateFaker(language).Lorem.Slug();
        }

        #endregion
    }
}