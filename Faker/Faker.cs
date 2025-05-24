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
        public string GetJobDescription(string language)
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
        /// Generates a random full address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random full address.</returns>
        public string GetFullAddress(string language)
        {
            return CreateFaker(language).Address.FullAddress();
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
        /// Generates a random country based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random country name.</returns>
        public string GetCountry(string language)
        {
            return CreateFaker(language).Address.Country();
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
    }
}