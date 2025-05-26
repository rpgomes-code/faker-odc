namespace Faker
{
    /// <summary>
    /// Image-related methods for the Faker class.
    /// This partial class contains all image generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Image Methods

        /// <summary>
        /// Generates a random image data uri based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image data uri.</returns>
        public string GetImage_DataUri(string language, int width, int length)
        {
            return CreateFaker(language).Image.DataUri(width, length);
        }

        /// <summary>
        /// Generates a random image picsum url based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image picsum url.</returns>
        public string GetImage_PicsumUrl(string language)
        {
            return CreateFaker(language).Image.PicsumUrl();
        }

        /// <summary>
        /// Generates a random image placeholder url based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image placeholder url.</returns>
        public string GetImage_PlaceholderUrl(string language, int width, int length)
        {
            return CreateFaker(language).Image.PlaceholderUrl(width, length);
        }

        /// <summary>
        /// Generates a random image lorem flickr url based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image lorem flickr url.</returns>
        public string GetImage_LoremFlickrUrl(string language)
        {
            return CreateFaker(language).Image.LoremFlickrUrl();
        }

        #endregion
    }
}