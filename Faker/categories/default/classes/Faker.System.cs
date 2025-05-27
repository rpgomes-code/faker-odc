namespace Faker
{
    /// <summary>
    /// System-related methods for the Faker class.
    /// This partial class contains all system generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region System Methods

        /// <summary>
        /// Generates a random file name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random file name.</returns>
        public string GetSystem_FileName(string language)
        {
            return CreateFaker(language).System.FileName();
        }

        /// <summary>
        /// Generates a random directory path based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random directory path.</returns>
        public string GetSystem_DirectoryPath(string language)
        {
            return CreateFaker(language).System.DirectoryPath();
        }

        /// <summary>
        /// Generates a random file path based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random file path.</returns>
        public string GetSystem_FilePath(string language)
        {
            return CreateFaker(language).System.FilePath();
        }

        /// <summary>
        /// Generates a random common file name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random common file name.</returns>
        public string GetSystem_CommonFileName(string language)
        {
            return CreateFaker(language).System.CommonFileName();
        }

        /// <summary>
        /// Generates a random mime type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random mime type.</returns>
        public string GetSystem_MimeType(string language)
        {
            return CreateFaker(language).System.MimeType();
        }

        /// <summary>
        /// Generates a random common file type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random common file type.</returns>
        public string GetSystem_CommonFileType(string language)
        {
            return CreateFaker(language).System.CommonFileType();
        }

        /// <summary>
        /// Generates a random common file extension based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random common file extension.</returns>
        public string GetSystem_CommonFileExt(string language)
        {
            return CreateFaker(language).System.CommonFileExt();
        }

        /// <summary>
        /// Generates a random file type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random file type.</returns>
        public string GetSystem_FileType(string language)
        {
            return CreateFaker(language).System.FileType();
        }

        /// <summary>
        /// Generates a random file extension based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random file extension.</returns>
        public string GetSystem_FileExt(string language)
        {
            return CreateFaker(language).System.FileExt();
        }

        /// <summary>
        /// Generates a random semver based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random semver.</returns>
        public string GetSystem_Semver(string language)
        {
            return CreateFaker(language).System.Semver();
        }

        /// <summary>
        /// Generates a random version as string based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random version as string.</returns>
        public string GetSystem_Version(string language)
        {
            return CreateFaker(language).System.Version().ToString();
        }

        /// <summary>
        /// Generates a random exception message based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random exception message.</returns>
        public string GetSystem_Exception(string language)
        {
            var exception = CreateFaker(language).System.Exception();
            return $"{exception.GetType().Name}: {exception.Message}";
        }

        /// <summary>
        /// Generates a random android id based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random android id.</returns>
        public string GetSystem_AndroidId(string language)
        {
            return CreateFaker(language).System.AndroidId();
        }

        /// <summary>
        /// Generates a random apple push token based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random apple push token.</returns>
        public string GetSystem_ApplePushToken(string language)
        {
            return CreateFaker(language).System.ApplePushToken();
        }

        /// <summary>
        /// Generates a random blackberry pin based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random blackberry pin.</returns>
        public string GetSystem_BlackBerryPin(string language)
        {
            return CreateFaker(language).System.BlackBerryPin();
        }

        #endregion
    }
}