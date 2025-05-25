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

        // Company related methods

        /// <summary>
        /// Generates a random company suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random company suffix.</returns>
        public string GetCompanySuffix(string language)
        {
            return CreateFaker(language).Company.CompanySuffix();
        }

        /// <summary>
        /// Generates a random company name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random company name.</returns>
        public string GetCompanyName(string language)
        {
            return CreateFaker(language).Company.CompanyName();
        }

        /// <summary>
        /// Generates a random catch phrase based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random catch phrase.</returns>
        public string GetCatchPhrase(string language)
        {
            return CreateFaker(language).Company.CatchPhrase();
        }

        /// <summary>
        /// Generates a random company BS based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random company BS.</returns>
        public string GetCompanyBs(string language)
        {
            return CreateFaker(language).Company.Bs();
        }

        // Database related methods

        /// <summary>
        /// Generates a random column based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random column.</returns>
        public string GetColumn(string language)
        {
            return CreateFaker(language).Database.Column();
        }

        /// <summary>
        /// Generates a random type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random type.</returns>
        public string GetType(string language)
        {
            return CreateFaker(language).Database.Type();
        }

        /// <summary>
        /// Generates a random collation based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random collation.</returns>
        public string GetCollation(string language)
        {
            return CreateFaker(language).Database.Collation();
        }

        /// <summary>
        /// Generates a random engine based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random engine.</returns>
        public string GetEngine(string language)
        {
            return CreateFaker(language).Database.Engine();
        }

        // Date related methods

        /// <summary>
        /// Generates a random past based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random past.</returns>
        public DateTime GetPast(string language)
        {
            return CreateFaker(language).Date.Past();
        }

        /// <summary>
        /// Generates a random past offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random past offset.</returns>
        public DateTimeOffset GetPastOffset(string language)
        {
            return CreateFaker(language).Date.PastOffset();
        }

        /// <summary>
        /// Generates a random soon based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random soon.</returns>
        public DateTime GetSoon(string language)
        {
            return CreateFaker(language).Date.Soon();
        }

        /// <summary>
        /// Generates a random soon offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random soon offset.</returns>
        public DateTimeOffset GetSoonOffset(string language)
        {
            return CreateFaker(language).Date.SoonOffset();
        }

        /// <summary>
        /// Generates a random future based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random future.</returns>
        public DateTime GetFuture(string language)
        {
            return CreateFaker(language).Date.Future();
        }

        /// <summary>
        /// Generates a random future offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random future offset.</returns>
        public DateTimeOffset GetFutureOffset(string language)
        {
            return CreateFaker(language).Date.FutureOffset();
        }

        /// <summary>
        /// Generates a random between based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random between.</returns>
        public DateTime GetBetween(string language, DateTime startDate, DateTime endDate)
        {
            return CreateFaker(language).Date.Between(startDate, endDate);
        }

        /// <summary>
        /// Generates a random between offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random between offset.</returns>
        public DateTimeOffset GetBetweenOffset(string language, DateTime startDate, DateTime endDate)
        {
            return CreateFaker(language).Date.BetweenOffset(startDate, endDate);
        }

        /// <summary>
        /// Generates a random recent based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random recent.</returns>
        public DateTime GetRecent(string language)
        {
            return CreateFaker(language).Date.Recent();
        }

        /// <summary>
        /// Generates a random recent offset based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random recent offset.</returns>
        public DateTimeOffset GetRecentOffset(string language)
        {
            return CreateFaker(language).Date.RecentOffset();
        }

        /// <summary>
        /// Generates a random timespan based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random timespan.</returns>
        public TimeSpan GetTimespan(string language)
        {
            return CreateFaker(language).Date.Timespan();
        }

        /// <summary>
        /// Generates a random month based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random month.</returns>
        public string GetMonth(string language)
        {
            return CreateFaker(language).Date.Month();
        }

        /// <summary>
        /// Generates a random weekday based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random weekday.</returns>
        public string GetWeekday(string language)
        {
            return CreateFaker(language).Date.Weekday();
        }

        // Finance related methods

        /// <summary>
        /// Generates a random account based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random account.</returns>
        public string GetAccount(string language)
        {
            return CreateFaker(language).Finance.Account();
        }

        /// <summary>
        /// Generates a random account name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random account name.</returns>
        public string GetAccountName(string language)
        {
            return CreateFaker(language).Finance.AccountName();
        }

        /// <summary>
        /// Generates a random amount based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random amount.</returns>
        public decimal GetAmount(string language)
        {
            return CreateFaker(language).Finance.Amount();
        }

        /// <summary>
        /// Generates a random transaction type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random transaction type.</returns>
        public string GetTransactionType(string language)
        {
            return CreateFaker(language).Finance.TransactionType();
        }

        /// <summary>
        /// Generates a random currency based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random currency.</returns>
        public string GetCurrency(string language)
        {
            return CreateFaker(language).Finance.Currency().ToString();
        }

        /// <summary>
        /// Generates a random credit card number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random credit card number.</returns>
        public string GetCreditCardNumber(string language)
        {
            return CreateFaker(language).Finance.CreditCardNumber();
        }

        /// <summary>
        /// Generates a random credit card CVV based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random credit card CVV.</returns>
        public string GetCreditCardCvv(string language)
        {
            return CreateFaker(language).Finance.CreditCardCvv();
        }

        /// <summary>
        /// Generates a random bitcoin address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random bitcoin address.</returns>
        public string GetBitcoinAddress(string language)
        {
            return CreateFaker(language).Finance.BitcoinAddress();
        }

        /// <summary>
        /// Generates a random ethereum address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random ethereum address.</returns>
        public string GetEthereumAddress(string language)
        {
            return CreateFaker(language).Finance.EthereumAddress();
        }

        /// <summary>
        /// Generates a random routing number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random routing number.</returns>
        public string GetRoutingNumber(string language)
        {
            return CreateFaker(language).Finance.RoutingNumber();
        }

        /// <summary>
        /// Generates a random BIC based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random BIC.</returns>
        public string GetBIC(string language)
        {
            return CreateFaker(language).Finance.Bic();
        }

        /// <summary>
        /// Generates a random IBAN based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IBAN.</returns>
        public string GetIBAN(string language)
        {
            return CreateFaker(language).Finance.Iban();
        }

        // Hacker related methods

        /// <summary>
        /// Generates a random hacker abbreviation based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker abbreviation.</returns>
        public string GetHackerAbbreviation(string language)
        {
            return CreateFaker(language).Hacker.Abbreviation();
        }

        /// <summary>
        /// Generates a random hacker adjective based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker adjective.</returns>
        public string GetHackerAdjective(string language)
        {
            return CreateFaker(language).Hacker.Adjective();
        }

        /// <summary>
        /// Generates a random hacker noun based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker noun.</returns>
        public string GetHackerNoun(string language)
        {
            return CreateFaker(language).Hacker.Noun();
        }

        /// <summary>
        /// Generates a random hacker verb based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker verb.</returns>
        public string GetHackerVerb(string language)
        {
            return CreateFaker(language).Hacker.Verb();
        }

        /// <summary>
        /// Generates a random hacker ing verb based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker ing verb.</returns>
        public string GetHackerIngVerb(string language)
        {
            return CreateFaker(language).Hacker.IngVerb();
        }

        /// <summary>
        /// Generates a random hacker phrase based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random hacker phrase.</returns>
        public string GetHackerPhrase(string language)
        {
            return CreateFaker(language).Hacker.Phrase();
        }

        // Image related methods

        /// <summary>
        /// Generates a random image data uri based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image data uri.</returns>
        public string GetImageDataUri(string language, int width, int length)
        {
            return CreateFaker(language).Image.DataUri(width, length);
        }

        /// <summary>
        /// Generates a random image picsum url based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image picsum url.</returns>
        public string GetImagePicsumUrl(string language)
        {
            return CreateFaker(language).Image.PicsumUrl();
        }

        /// <summary>
        /// Generates a random image placeholder url based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image placeholder url.</returns>
        public string GetImagePlaceholderUrl(string language, int width, int length)
        {
            return CreateFaker(language).Image.PlaceholderUrl(width, length);
        }

        /// <summary>
        /// Generates a random image lorem flickr url based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random image lorem flickr url.</returns>
        public string GetImageLoremFlickrUrl(string language)
        {
            return CreateFaker(language).Image.LoremFlickrUrl();
        }

        // Internet related methods

        /// <summary>
        /// Generates a random avatar based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random avatar.</returns>
        public string GetAvatar(string language)
        {
            return CreateFaker(language).Internet.Avatar();
        }

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
        /// Generates a random example email address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random example email address.</returns>
        public string GetExampleEmail(string language)
        {
            return CreateFaker(language).Internet.ExampleEmail();
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
        /// Generates a random username unicode based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random username unicode.</returns>
        public string GetUserNameUnicode(string language)
        {
            return CreateFaker(language).Internet.UserNameUnicode();
        }

        /// <summary>
        /// Generates a random domain name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random domain name.</returns>
        public string GetDomainName(string language)
        {
            return CreateFaker(language).Internet.DomainName();
        }

        /// <summary>
        /// Generates a random domain word based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random domain word.</returns>
        public string GetDomainWord(string language)
        {
            return CreateFaker(language).Internet.DomainWord();
        }

        /// <summary>
        /// Generates a random domain suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random domain suffix.</returns>
        public string GetDomainSuffix(string language)
        {
            return CreateFaker(language).Internet.DomainSuffix();
        }

        /// <summary>
        /// Generates a random IPv4 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv4 address.</returns>
        public string GetIP(string language)
        {
            return CreateFaker(language).Internet.Ip();
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
        /// Generates a random IPv4 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv4 address.</returns>
        public string GetIpAddress(string language)
        {
            return CreateFaker(language).Internet.IpAddress().ToString();
        }

        /// <summary>
        /// Generates a random IPv4 endpoint based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv4 endpoint.</returns>
        public string GetIpEndPoint(string language)
        {
            return CreateFaker(language).Internet.IpEndPoint().ToString();
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
        /// Generates a random IPv6 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv6 address.</returns>
        public string GetIpv6Address(string language)
        {
            return CreateFaker(language).Internet.Ipv6Address().ToString();
        }

        /// <summary>
        /// Generates a random IPv6 endpoint based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv6 endpoint.</returns>
        public string GetIpv6EndPoint(string language)
        {
            return CreateFaker(language).Internet.Ipv6EndPoint().ToString();
        }

        /// <summary>
        /// Generates a random user agent based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random user agent.</returns>
        public string GetUserAgent(string language)
        {
            return CreateFaker(language).Internet.UserAgent();
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
        /// Generates a random internet color based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random internet color.</returns>
        public string GetInternetColor(string language)
        {
            return CreateFaker(language).Internet.Color();
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

        /// <summary>
        /// Generates a random url with path based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random url with path.</returns>
        public string GetUrlWithPath(string language)
        {
            return CreateFaker(language).Internet.UrlWithPath();
        }

        /// <summary>
        /// Generates a random url rooted path based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random url rooted path.</returns>
        public string GetUrlRootedPath(string language)
        {
            return CreateFaker(language).Internet.UrlRootedPath();
        }

        // Lorem related methods

        /// <summary>
        /// Generates a random lorem word based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem word.</returns>
        public string GetLoremWord(string language)
        {
            return CreateFaker(language).Lorem.Word();
        }

        /// <summary>
        /// Generates a random lorem words based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem words.</returns>
        public string[] GetLoremWords(string language)
        {
            return CreateFaker(language).Lorem.Words();
        }

        /// <summary>
        /// Generates a random lorem letter based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem letter.</returns>
        public string GetLoremLetter(string language)
        {
            return CreateFaker(language).Lorem.Letter();
        }

        /// <summary>
        /// Generates a random lorem sentence based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem sentence.</returns>
        public string GetLoremSentence(string language)
        {
            return CreateFaker(language).Lorem.Sentence();
        }

        /// <summary>
        /// Generates a random lorem sentences based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem sentences.</returns>
        public string GetLoremSentences(string language)
        {
            return CreateFaker(language).Lorem.Sentences();
        }

        /// <summary>
        /// Generates a random lorem paragraph based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem paragraph.</returns>
        public string GetLoremParagraph(string language)
        {
            return CreateFaker(language).Lorem.Paragraph();
        }

        /// <summary>
        /// Generates a random lorem paragraphs based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem paragraphs.</returns>
        public string GetLoremParagraphs(string language)
        {
            return CreateFaker(language).Lorem.Paragraphs();
        }

        /// <summary>
        /// Generates a random lorem text based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem text.</returns>
        public string GetLoremText(string language)
        {
            return CreateFaker(language).Lorem.Text();
        }

        /// <summary>
        /// Generates a random lorem lines based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem lines.</returns>
        public string GetLoremLines(string language)
        {
            return CreateFaker(language).Lorem.Lines();
        }

        /// <summary>
        /// Generates a random lorem slug based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random lorem slug.</returns>
        public string GetLoremSlug(string language)
        {
            return CreateFaker(language).Lorem.Slug();
        }

        // Name related methods

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
        /// Generates a random name prefix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random name prefix.</returns>
        public string GetNamePrefix(string language)
        {
            return CreateFaker(language).Name.Prefix();
        }

        /// <summary>
        /// Generates a random name suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random name suffix.</returns>
        public string GetNameSuffix(string language)
        {
            return CreateFaker(language).Name.Suffix();
        }

        /// <summary>
        /// Generates a random full name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random full name.</returns>
        public string GetNameFindName(string language)
        {
            return CreateFaker(language).Name.FindName();
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

        /// <summary>
        /// Generates a random phone number formated based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random phone number formated.</returns>
        public string GetPhoneNumberFormated(string language)
        {
            return CreateFaker(language).Phone.PhoneNumberFormat();
        }

        // Review related methods

        /// <summary>
        /// Generates a random review based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random review.</returns>
        public string GetRantReview(string language)
        {
            return CreateFaker(language).Rant.Review();
        }

        /// <summary>
        /// Generates a random reviews based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random reviews.</returns>
        public string[] GetRantReviews(string language)
        {
            return CreateFaker(language).Rant.Reviews();
        }

        // System related methods

        /// <summary>
        /// Generates a random file name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random file name.</returns>
        public string GetSystemFileName(string language)
        {
            return CreateFaker(language).System.FileName();
        }
    }
}