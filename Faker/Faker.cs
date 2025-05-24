using Bogus;
using System;
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// The Faker class implements the IFaker interface, providing
    /// the actual functionality for generating realistic fake/demo data
    /// using the Bogus library with multilingual support.
    /// </summary>
    public class Faker : IFaker
    {
        /// <summary>
        /// A HashSet containing all valid locale codes supported by the Bogus library.
        /// Used for locale validation and fallback to default locale.
        /// </summary>
        private static readonly HashSet<string> ValidLocales = new(StringComparer.OrdinalIgnoreCase)
        {
            "af_ZA", "ar", "az", "cz", "de", "de_AT", "de_CH", "el", "en", "en_AU", "en_AU_ocker", "en_BORK",
            "en_CA", "en_GB", "en_IE", "en_IND", "en_NG", "en_US", "en_ZA", "es", "es_MX", "fa", "fi", "fr",
            "fr_CA", "fr_CH", "ge", "hr", "id_ID", "it", "ja", "ko", "lv", "nb_NO", "ne", "nl", "nl_BE",
            "pl", "pt_BR", "pt_PT", "ro", "ru", "sk", "sv", "tr", "uk", "vi", "zh_CN", "zh_TW", "zu_ZA"
        };

        /// <summary>
        /// The default locale to use when an invalid or unsupported locale is provided.
        /// </summary>
        private const string DefaultLocale = "en";

        /// <summary>
        /// Maps the provided language code to a valid Bogus locale.
        /// If the language is not supported, returns the default locale.
        /// </summary>
        /// <param name="language">The language code to map.</param>
        /// <returns>A valid Bogus locale string.</returns>
        private static string GetMappedLocale(string language)
        {
            if (string.IsNullOrWhiteSpace(language))
                return DefaultLocale;

            var normalized = language.Trim();
            return ValidLocales.Contains(normalized) ? normalized : DefaultLocale;
        }

        /// <summary>
        /// Creates a new Bogus.Faker instance with the specified language locale.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A configured Bogus.Faker instance.</returns>
        private static Bogus.Faker CreateFaker(string language)
        {
            var locale = GetMappedLocale(language);
            return new Bogus.Faker(locale);
        }

        // Name related methods

        /// <summary>
        /// Generates a random full name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random full name.</returns>
        public string GetFullName(string language)
        {
            return CreateFaker(language).Name.FullName();
        }

        /// <summary>
        /// Generates a random first name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random first name.</returns>
        public string GetFirstName(string language)
        {
            return CreateFaker(language).Name.FirstName();
        }

        /// <summary>
        /// Generates a random last name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random last name.</returns>
        public string GetLastName(string language)
        {
            return CreateFaker(language).Name.LastName();
        }

        // Job related methods

        /// <summary>
        /// Generates a random job area based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job area.</returns>
        public string GetJobArea(string language)
        {
            return CreateFaker(language).Name.JobArea();
        }

        /// <summary>
        /// Generates a random job type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job type.</returns>
        public string GetJobType(string language)
        {
            return CreateFaker(language).Name.JobType();
        }

        /// <summary>
        /// Generates a random job title based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job title.</returns>
        public string GetJobTitle(string language)
        {
            return CreateFaker(language).Name.JobTitle();
        }

        /// <summary>
        /// Generates a random job descriptor based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random job descriptor.</returns>
        public string GetJobDescriptor(string language)
        {
            return CreateFaker(language).Name.JobDescriptor();
        }

        // Phone related methods

        /// <summary>
        /// Generates a random phone number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random phone number.</returns>
        public string GetPhoneNumber(string language)
        {
            return CreateFaker(language).Phone.PhoneNumber();
        }

        // Internet related methods

        /// <summary>
        /// Generates a random email address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random email address.</returns>
        public string GetEmail(string language)
        {
            return CreateFaker(language).Internet.Email();
        }

        /// <summary>
        /// Generates a random IPv4 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv4 address.</returns>
        public string GetIPv4(string language)
        {
            return CreateFaker(language).Internet.Ip();
        }

        /// <summary>
        /// Generates a random IPv6 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv6 address.</returns>
        public string GetIPv6(string language)
        {
            return CreateFaker(language).Internet.Ipv6();
        }

        /// <summary>
        /// Generates a random MAC address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random MAC address.</returns>
        public string GetMac(string language)
        {
            return CreateFaker(language).Internet.Mac();
        }

        /// <summary>
        /// Generates a random password based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random password.</returns>
        public string GetPassword(string language)
        {
            return CreateFaker(language).Internet.Password();
        }

        /// <summary>
        /// Generates a random port number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random port number.</returns>
        public int GetPort(string language)
        {
            return CreateFaker(language).Internet.Port();
        }

        /// <summary>
        /// Generates a random username based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random username.</returns>
        public string GetUserName(string language)
        {
            return CreateFaker(language).Internet.UserName();
        }

        /// <summary>
        /// Generates a random protocol based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random protocol.</returns>
        public string GetProtocol(string language)
        {
            return CreateFaker(language).Internet.Protocol();
        }

        /// <summary>
        /// Generates a random URL based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random URL.</returns>
        public string GetUrl(string language)
        {
            return CreateFaker(language).Internet.Url();
        }

        // Address related methods

        /// <summary>
        /// Generates a random zip code based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random zip code.</returns>
        public string GetZipCode(string language)
        {
            return CreateFaker(language).Address.ZipCode();
        }

        /// <summary>
        /// Generates a random city based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random city name.</returns>
        public string GetCity(string language)
        {
            return CreateFaker(language).Address.City();
        }

        /// <summary>
        /// Generates a random street address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random street address.</returns>
        public string GetStreetAddress(string language)
        {
            return CreateFaker(language).Address.StreetAddress();
        }

        /// <summary>
        /// Generates a random city prefix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random city prefix.</returns>
        public string GetCityPrefix(string language)
        {
            return CreateFaker(language).Address.CityPrefix();
        }

        /// <summary>
        /// Generates a random city suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random city suffix.</returns>
        public string GetCitySuffix(string language)
        {
            return CreateFaker(language).Address.CitySuffix();
        }

        /// <summary>
        /// Generates a random street name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random street name.</returns>
        public string GetStreetName(string language)
        {
            return CreateFaker(language).Address.StreetName();
        }

        /// <summary>
        /// Generates a random building number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random building number.</returns>
        public string GetBuildingNumber(string language)
        {
            return CreateFaker(language).Address.BuildingNumber();
        }

        /// <summary>
        /// Generates a random street suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random street suffix.</returns>
        public string GetStreetSuffix(string language)
        {
            return CreateFaker(language).Address.StreetSuffix();
        }

        /// <summary>
        /// Generates a random secondary address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random secondary address.</returns>
        public string GetSecondaryAddress(string language)
        {
            return CreateFaker(language).Address.SecondaryAddress();
        }

        /// <summary>
        /// Generates a random county based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random county.</returns>
        public string GetCounty(string language)
        {
            return CreateFaker(language).Address.County();
        }

        /// <summary>
        /// Generates a random country based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random country name.</returns>
        public string GetCountry(string language)
        {
            return CreateFaker(language).Address.Country();
        }

        /// <summary>
        /// Generates a random full address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random full address.</returns>
        public string GetFullAddress(string language)
        {
            return CreateFaker(language).Address.FullAddress();
        }

        /// <summary>
        /// Generates a random country code based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random country code.</returns>
        public string GetCountryCode(string language)
        {
            return CreateFaker(language).Address.CountryCode();
        }

        /// <summary>
        /// Generates a random state based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random state or region name.</returns>
        public string GetState(string language)
        {
            return CreateFaker(language).Address.State();
        }

        /// <summary>
        /// Generates a random state abbreviation based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random state abbreviation.</returns>
        public string GetStateAbbreviation(string language)
        {
            return CreateFaker(language).Address.StateAbbr();
        }

        /// <summary>
        /// Generates a random latitude based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random latitude.</returns>
        public double GetLatitude(string language)
        {
            return CreateFaker(language).Address.Latitude();
        }

        /// <summary>
        /// Generates a random longitude based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random longitude.</returns>
        public double GetLongitude(string language)
        {
            return CreateFaker(language).Address.Longitude();
        }

        /// <summary>
        /// Generates a random direction based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random direction.</returns>
        public string GetDirection(string language)
        {
            return CreateFaker(language).Address.Direction();
        }

        /// <summary>
        /// Generates a random cardinal direction based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random cardinal direction.</returns>
        public string GetCardinalDirection(string language)
        {
            return CreateFaker(language).Address.CardinalDirection();
        }

        /// <summary>
        /// Generates a random ordinal direction based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random ordinal direction.</returns>
        public string GetOrdinalDirection(string language)
        {
            return CreateFaker(language).Address.OrdinalDirection();
        }

        // Commerce related methods

        /// <summary>
        /// Generates a random department based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random department.</returns>
        public string GetDepartment(string language)
        {
            return CreateFaker(language).Commerce.Department();
        }

        /// <summary>
        /// Generates a random price based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random price.</returns>
        public string GetPrice(string language)
        {
            return CreateFaker(language).Commerce.Price();
        }

        /// <summary>
        /// Generates a random category based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random category.</returns>
        public string GetCategory(string language)
        {
            return CreateFaker(language).Commerce.Categories(1)[0];
        }

        /// <summary>
        /// Generates a random product name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random product name.</returns>
        public string GetProductName(string language)
        {
            return CreateFaker(language).Commerce.ProductName();
        }

        /// <summary>
        /// Generates a random color based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random color.</returns>
        public string GetColor(string language)
        {
            return CreateFaker(language).Commerce.Color();
        }

        /// <summary>
        /// Generates a random product adjective based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random product adjective.</returns>
        public string GetProductAdjective(string language)
        {
            return CreateFaker(language).Commerce.ProductAdjective();
        }

        /// <summary>
        /// Generates a random product material based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random product material.</returns>
        public string GetProductMaterial(string language)
        {
            return CreateFaker(language).Commerce.ProductMaterial();
        }

        /// <summary>
        /// Generates a random Ean8 based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Ean8.</returns>
        public string GetEan8(string language)
        {
            return CreateFaker(language).Commerce.Ean8();
        }

        /// <summary>
        /// Generates a random Ean13 based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Ean13.</returns>
        public string GetEan13(string language)
        {
            return CreateFaker(language).Commerce.Ean13();
        }
    }
}