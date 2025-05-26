namespace Faker
{
    /// <summary>
    /// Date-related methods for the Faker class.
    /// This partial class contains all date generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Date Methods

        /// <summary>
        /// Generates a random date past based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date past.</returns>
        public DateTime GetDate_Past(string language)
        {
            return CreateFaker(language).Date.Past();
        }

        /// <summary>
        /// Generates a random date past offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date past offset.</returns>
        public DateTimeOffset GetDate_PastOffset(string language)
        {
            return CreateFaker(language).Date.PastOffset();
        }

        /// <summary>
        /// Generates a random date soon based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date soon.</returns>
        public DateTime GetDate_Soon(string language)
        {
            return CreateFaker(language).Date.Soon();
        }

        /// <summary>
        /// Generates a random date soon offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date soon offset.</returns>
        public DateTimeOffset GetDate_SoonOffset(string language)
        {
            return CreateFaker(language).Date.SoonOffset();
        }

        /// <summary>
        /// Generates a random date future based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date future.</returns>
        public DateTime GetDate_Future(string language)
        {
            return CreateFaker(language).Date.Future();
        }

        /// <summary>
        /// Generates a random date future offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date future offset.</returns>
        public DateTimeOffset GetDate_FutureOffset(string language)
        {
            return CreateFaker(language).Date.FutureOffset();
        }

        /// <summary>
        /// Generates a random date between based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date between.</returns>
        public DateTime GetDate_Between(string language, DateTime startDate, DateTime endDate)
        {
            return CreateFaker(language).Date.Between(startDate, endDate);
        }

        /// <summary>
        /// Generates a random date between offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date between offset.</returns>
        public DateTimeOffset GetDate_BetweenOffset(string language, DateTime startDate, DateTime endDate)
        {
            return CreateFaker(language).Date.BetweenOffset(startDate, endDate);
        }

        /// <summary>
        /// Generates a random date recent based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date recent.</returns>
        public DateTime GetDate_Recent(string language)
        {
            return CreateFaker(language).Date.Recent();
        }

        /// <summary>
        /// Generates a random date recent offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date recent offset.</returns>
        public DateTimeOffset GetDate_RecentOffset(string language)
        {
            return CreateFaker(language).Date.RecentOffset();
        }

        /// <summary>
        /// Generates a random date timespan based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random date timespan.</returns>
        public TimeSpan GetDate_Timespan(string language)
        {
            return CreateFaker(language).Date.Timespan();
        }

        /// <summary>
        /// Generates a random month based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random month.</returns>
        public string GetDate_Month(string language)
        {
            return CreateFaker(language).Date.Month();
        }

        /// <summary>
        /// Generates a random weekday based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random weekday.</returns>
        public string GetDate_Weekday(string language)
        {
            return CreateFaker(language).Date.Weekday();
        }

        #endregion
    }
}