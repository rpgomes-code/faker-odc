namespace Faker
{
    /// <summary>
    /// Address-related methods for the Faker class.
    /// This partial class contains all address generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Address Methods

        /// <summary>
        /// Generates a random address zip code based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random address zip code.</returns>
        public string GetAddress_ZipCode(string language)
        {
            return CreateFaker(language).Address.ZipCode();
        }

        /// <summary>
        /// Generates a random city based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random city name.</returns>
        public string GetAddress_City(string language)
        {
            return CreateFaker(language).Address.City();
        }

        /// <summary>
        /// Generates a random street address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random street address.</returns>
        public string GetAddress_StreetAddress(string language)
        {
            return CreateFaker(language).Address.StreetAddress();
        }

        /// <summary>
        /// Generates a random city prefix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random city prefix.</returns>
        public string GetAddress_CityPrefix(string language)
        {
            return CreateFaker(language).Address.CityPrefix();
        }

        /// <summary>
        /// Generates a random city suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random city suffix.</returns>
        public string GetAddress_CitySuffix(string language)
        {
            return CreateFaker(language).Address.CitySuffix();
        }

        /// <summary>
        /// Generates a random street name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random street name.</returns>
        public string GetAddress_StreetName(string language)
        {
            return CreateFaker(language).Address.StreetName();
        }

        /// <summary>
        /// Generates a random building number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random building number.</returns>
        public string GetAddress_BuildingNumber(string language)
        {
            return CreateFaker(language).Address.BuildingNumber();
        }

        /// <summary>
        /// Generates a random street suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random street suffix.</returns>
        public string GetAddress_StreetSuffix(string language)
        {
            return CreateFaker(language).Address.StreetSuffix();
        }

        /// <summary>
        /// Generates a random secondary address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random secondary address.</returns>
        public string GetAddress_SecondaryAddress(string language)
        {
            return CreateFaker(language).Address.SecondaryAddress();
        }

        /// <summary>
        /// Generates a random county based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random county.</returns>
        public string GetAddress_County(string language)
        {
            return CreateFaker(language).Address.County();
        }

        /// <summary>
        /// Generates a random country based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random country name.</returns>
        public string GetAddress_Country(string language)
        {
            return CreateFaker(language).Address.Country();
        }

        /// <summary>
        /// Generates a random full address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random full address.</returns>
        public string GetAddress_FullAddress(string language)
        {
            return CreateFaker(language).Address.FullAddress();
        }

        /// <summary>
        /// Generates a random country code based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random country code.</returns>
        public string GetAddress_CountryCode(string language)
        {
            return CreateFaker(language).Address.CountryCode();
        }

        /// <summary>
        /// Generates a random state based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random state or region name.</returns>
        public string GetAddress_State(string language)
        {
            return CreateFaker(language).Address.State();
        }

        /// <summary>
        /// Generates a random state abbreviation based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random state abbreviation.</returns>
        public string GetAddress_StateAbbreviation(string language)
        {
            return CreateFaker(language).Address.StateAbbr();
        }

        /// <summary>
        /// Generates a random latitude based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random latitude.</returns>
        public double GetAddress_Latitude(string language)
        {
            return CreateFaker(language).Address.Latitude();
        }

        /// <summary>
        /// Generates a random longitude based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random longitude.</returns>
        public double GetAddress_Longitude(string language)
        {
            return CreateFaker(language).Address.Longitude();
        }

        /// <summary>
        /// Generates a random direction based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random direction.</returns>
        public string GetAddress_Direction(string language)
        {
            return CreateFaker(language).Address.Direction();
        }

        /// <summary>
        /// Generates a random cardinal direction based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random cardinal direction.</returns>
        public string GetAddress_CardinalDirection(string language)
        {
            return CreateFaker(language).Address.CardinalDirection();
        }

        /// <summary>
        /// Generates a random ordinal direction based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random ordinal direction.</returns>
        public string GetAddress_OrdinalDirection(string language)
        {
            return CreateFaker(language).Address.OrdinalDirection();
        }

        #endregion
    }
}