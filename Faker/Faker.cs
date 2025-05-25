using Bogus;
using System;
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// The main Faker class implements the IFaker interface, providing
    /// the actual functionality for generating realistic fake/demo data
    /// using the Bogus library with multilingual support.
    /// This is a partial class split across multiple files for better organization.
    /// </summary>
    public partial class Faker : IFaker
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
    }
}