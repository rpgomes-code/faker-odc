using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// The IFaker interface defines methods for generating realistic fake/demo data
    /// such as names, emails, phone numbers, addresses, and job titles with multilingual support.
    /// </summary>
    [OSInterface(
        Name = "Faker",
        Description = "A utility library for generating realistic fake/demo data such as names, emails, phone numbers, addresses, job titles, and internet-related data. Useful for testing, prototyping, and seeding applications with multilingual support.",
        IconResourceName = "Faker.resources.Logo.png"
    )]
    public interface IFaker
    {
        // Address related methods
        /// <summary>
        /// Gets a random zip code based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random zip code based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ZipCode",
            ReturnType = OSDataType.Text
        )]
        string GetZipCode(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random city based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random city based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "City",
            ReturnType = OSDataType.Text
        )]
        string GetCity(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random street address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random street address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StreetAddress",
            ReturnType = OSDataType.Text
        )]
        string GetStreetAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random city prefix based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random city prefix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CityPrefix",
            ReturnType = OSDataType.Text
        )]
        string GetCityPrefix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random city suffix based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random city suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CitySuffix",
            ReturnType = OSDataType.Text
        )]
        string GetCitySuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random street name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random street name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StreetName",
            ReturnType = OSDataType.Text
        )]
        string GetStreetName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random building number based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random building number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BuildingNumber",
            ReturnType = OSDataType.Text
        )]
        string GetBuildingNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random street suffix based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random street suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StreetSuffix",
            ReturnType = OSDataType.Text
        )]
        string GetStreetSuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random secondary address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random secondary address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "SecondaryAddress",
            ReturnType = OSDataType.Text
        )]
        string GetSecondaryAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random county based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random county based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "County",
            ReturnType = OSDataType.Text
        )]
        string GetCounty(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random country based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random country based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Country",
            ReturnType = OSDataType.Text
        )]
        string GetCountry(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random full address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random full address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FullAddress",
            ReturnType = OSDataType.Text
        )]
        string GetFullAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random country code based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random country code based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CountryCode",
            ReturnType = OSDataType.Text
        )]
        string GetCountryCode(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random state based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random state based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "State",
            ReturnType = OSDataType.Text
        )]
        string GetState(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random state abbreviation based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random state abbreviation based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StateAbbreviation",
            ReturnType = OSDataType.Text
        )]
        string GetStateAbbreviation(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random latitude based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random latitude based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Latitude",
            ReturnType = OSDataType.Decimal
        )]
        double GetLatitude(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random longitude based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random longitude based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Longitude",
            ReturnType = OSDataType.Decimal
        )]
        double GetLongitude(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random direction based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random direction based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Direction",
            ReturnType = OSDataType.Text
        )]
        string GetDirection(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random cardinal direction based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random cardinal direction based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CardinalDirection",
            ReturnType = OSDataType.Text
        )]
        string GetCardinalDirection(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random ordinal direction based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random ordinal direction based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "OrdinalDirection",
            ReturnType = OSDataType.Text
        )]
        string GetOrdinalDirection(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Commerce related methods
        /// <summary>
        /// Gets a random department based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random department based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Department",
            ReturnType = OSDataType.Text
        )]
        string GetDepartment(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random price based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random price based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Price",
            ReturnType = OSDataType.Text
        )]
        string GetPrice(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random category based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random category based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Category",
            ReturnType = OSDataType.Text
        )]
        string GetCategory(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random product name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random product name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ProductName",
            ReturnType = OSDataType.Text
        )]
        string GetProductName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random color based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random color based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Color",
            ReturnType = OSDataType.Text
        )]
        string GetColor(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random product adjective based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random product adjective based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ProductAdjective",
            ReturnType = OSDataType.Text
        )]
        string GetProductAdjective(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random product material based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random product material based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ProductMaterial",
            ReturnType = OSDataType.Text
        )]
        string GetProductMaterial(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random Ean8 based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random Ean8 based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Ean8",
            ReturnType = OSDataType.Text
        )]
        string GetEan8(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random Ean13 based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random Ean13 based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Ean13",
            ReturnType = OSDataType.Text
        )]
        string GetEan13(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Company related methods
        /// <summary>
        /// Gets a random company suffix based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random company suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CompanySuffix",
            ReturnType = OSDataType.Text
        )]
        string GetCompanySuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random company name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random company name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CompanyName",
            ReturnType = OSDataType.Text
        )]
        string GetCompanyName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random catch phrase based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random catch phrase based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CatchPhrase",
            ReturnType = OSDataType.Text
        )]
        string GetCatchPhrase(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random company BS based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random company BS based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CompanyBs",
            ReturnType = OSDataType.Text
        )]
        string GetCompanyBs(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Database related methods
        /// <summary>
        /// Gets a random column based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random column based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Column",
            ReturnType = OSDataType.Text
        )]
        string GetColumn(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random type based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Type",
            ReturnType = OSDataType.Text
        )]
        string GetType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random collation based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random collation based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Collation",
            ReturnType = OSDataType.Text
        )]
        string GetCollation(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random engine based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random engine based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Engine",
            ReturnType = OSDataType.Text
        )]
        string GetEngine(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Date related methods
        /// <summary>
        /// Gets a random past based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random past based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Past",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetPast(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random soon based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random soon based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Soon",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetSoon(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random future based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random future based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Future",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetFuture(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random recent based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random recent based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Recent",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetRecent(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random month based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random month based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Month",
            ReturnType = OSDataType.Text
        )]
        string GetMonth(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random weekday based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random weekday based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Weekday",
            ReturnType = OSDataType.Text
        )]
        string GetWeekday(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Finance related methods
        /// <summary>
        /// Gets a random account based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random account based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Account",
            ReturnType = OSDataType.Text
        )]
        string GetAccount(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random account name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random account name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "AccountName",
            ReturnType = OSDataType.Text
        )]
        string GetAccountName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random amount based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random amount based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Amount",
            ReturnType = OSDataType.Decimal
        )]
        decimal GetAmount(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random transaction type based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random transaction type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "TransactionType",
            ReturnType = OSDataType.Text
        )]
        string GetTransactionType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random currency based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random currency based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Currency",
            ReturnType = OSDataType.Text
        )]
        string GetCurrency(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random credit card number based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random credit card number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CreditCardNumber",
            ReturnType = OSDataType.Text
        )]
        string GetCreditCardNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random credit card CVV based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random credit card CVV based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CreditCardCvv",
            ReturnType = OSDataType.Text
        )]
        string GetCreditCardCvv(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random bitcoin address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random bitcoin address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BitcoinAddress",
            ReturnType = OSDataType.Text
        )]
        string GetBitcoinAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random ethereum address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random ethereum address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "EthereumAddress",
            ReturnType = OSDataType.Text
        )]
        string GetEthereumAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random routing number based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random routing number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "RoutingNumber",
            ReturnType = OSDataType.Text
        )]
        string GetRoutingNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random BIC based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random BIC based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BIC",
            ReturnType = OSDataType.Text
        )]
        string GetBIC(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random IBAN based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random IBAN based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IBAN",
            ReturnType = OSDataType.Text
        )]
        string GetIBAN(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Hacker related methods
        /// <summary>
        /// Gets a random hacker abbreviation based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random hacker abbreviation based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerAbbreviation",
            ReturnType = OSDataType.Text
        )]
        string GetHackerAbbreviation(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random hacker adjective based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random hacker adjective based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerAdjective",
            ReturnType = OSDataType.Text
        )]
        string GetHackerAdjective(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random hacker noun based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random hacker noun based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerNoun",
            ReturnType = OSDataType.Text
        )]
        string GetHackerNoun(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random hacker verb based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random hacker verb based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerVerb",
            ReturnType = OSDataType.Text
        )]
        string GetHackerVerb(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random hacker ing verb based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random hacker ing verb based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerIngVerb",
            ReturnType = OSDataType.Text
        )]
        string GetHackerIngVerb(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random hacker phrase based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random hacker phrase based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerPhrase",
            ReturnType = OSDataType.Text
        )]
        string GetHackerPhrase(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Internet related methods
        /// <summary>
        /// Gets a random avatar based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random avatar based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Avatar",
            ReturnType = OSDataType.Text
        )]
        string GetAvatar(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random email address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random email address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Email",
            ReturnType = OSDataType.Text
        )]
        string GetEmail(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random example email address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random example email address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ExampleEmail",
            ReturnType = OSDataType.Text
        )]
        string GetExampleEmail(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random username based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random username based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Username",
            ReturnType = OSDataType.Text
        )]
        string GetUserName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random username unicode based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random username unicode based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UserNameUnicode",
            ReturnType = OSDataType.Text
        )]
        string GetUserNameUnicode(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random domain name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random domain name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DomainName",
            ReturnType = OSDataType.Text
        )]
        string GetDomainName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random domain word based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random domain word based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DomainWord",
            ReturnType = OSDataType.Text
        )]
        string GetDomainWord(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random domain suffix based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random domain suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DomainSuffix",
            ReturnType = OSDataType.Text
        )]
        string GetDomainSuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random IPv4 address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random IPv4 address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IPv4Address",
            ReturnType = OSDataType.Text
        )]
        string GetIP(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random port number based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random port number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Port",
            ReturnType = OSDataType.Integer
        )]
        int GetPort(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random IPv6 address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random IPv6 address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IPv6Address",
            ReturnType = OSDataType.Text
        )]
        string GetIPv6(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random user agent based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random user agent based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UserAgent",
            ReturnType = OSDataType.Text
        )]
        string GetUserAgent(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random MAC address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random MAC address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "MacAddress",
            ReturnType = OSDataType.Text
        )]
        string GetMac(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random password based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random password based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Password",
            ReturnType = OSDataType.Text
        )]
        string GetPassword(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random internet color based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random internet color based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "InternetColor",
            ReturnType = OSDataType.Text
        )]
        string GetInternetColor(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random protocol based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random protocol based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Protocol",
            ReturnType = OSDataType.Text
        )]
        string GetProtocol(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random URL based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random URL based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Url",
            ReturnType = OSDataType.Text
        )]
        string GetUrl(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random url with path based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random url with path based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UrlWithPath",
            ReturnType = OSDataType.Text
        )]
        string GetUrlWithPath(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random url rooted path based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random url rooted path based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UrlRootedPath",
            ReturnType = OSDataType.Text
        )]
        string GetUrlRootedPath(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Lorem related methods
        /// <summary>
        /// Gets a random lorem word based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem word based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremWord",
            ReturnType = OSDataType.Text
        )]
        string GetLoremWord(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem letter based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem letter based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremLetter",
            ReturnType = OSDataType.Text
        )]
        string GetLoremLetter(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem sentence based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem sentence based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremSentence",
            ReturnType = OSDataType.Text
        )]
        string GetLoremSentence(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem sentences based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem sentences based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremSentences",
            ReturnType = OSDataType.Text
        )]
        string GetLoremSentences(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem paragraph based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem paragraph based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremParagraph",
            ReturnType = OSDataType.Text
        )]
        string GetLoremParagraph(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem paragraphs based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem paragraphs based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremParagraphs",
            ReturnType = OSDataType.Text
        )]
        string GetLoremParagraphs(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem text based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem text based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremText",
            ReturnType = OSDataType.Text
        )]
        string GetLoremText(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem lines based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem lines based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremLines",
            ReturnType = OSDataType.Text
        )]
        string GetLoremLines(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random lorem slug based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random lorem slug based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremSlug",
            ReturnType = OSDataType.Text
        )]
        string GetLoremSlug(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Name related methods
        /// <summary>
        /// Gets a random first name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random first name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FirstName",
            ReturnType = OSDataType.Text
        )]
        string GetFirstName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'fr', 'de')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random last name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random last name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LastName",
            ReturnType = OSDataType.Text
        )]
        string GetLastName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'it')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random full name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random full name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FullName",
            ReturnType = OSDataType.Text
        )]
        string GetFullName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random name prefix based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random name prefix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "NamePrefix",
            ReturnType = OSDataType.Text
        )]
        string GetNamePrefix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random name suffix based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random name suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "NameSuffix",
            ReturnType = OSDataType.Text
        )]
        string GetNameSuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random full name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random full name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FindName",
            ReturnType = OSDataType.Text
        )]
        string GetNameFindName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random job title based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job title based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobTitle",
            ReturnType = OSDataType.Text
        )]
        string GetJobTitle(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random job descriptor based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job descriptor based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobDescription",
            ReturnType = OSDataType.Text
        )]
        string GetJobDescriptor(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random job area based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job area based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobArea",
            ReturnType = OSDataType.Text
        )]
        string GetJobArea(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random job type based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobType",
            ReturnType = OSDataType.Text
        )]
        string GetJobType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Phone related methods
        /// <summary>
        /// Gets a random phone number based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random phone number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PhoneNumber",
            ReturnType = OSDataType.Text
        )]
        string GetPhoneNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random phone number formated based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random phone number formated based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PhoneNumberFormated",
            ReturnType = OSDataType.Text
        )]
        string GetPhoneNumberFormated(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Review related methods
        /// <summary>
        /// Gets a random review based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random review based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "RantReview",
            ReturnType = OSDataType.Text
        )]
        string GetRantReview(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // System related methods
        /// <summary>
        /// Gets a random file name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random file name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "SystemFileName",
            ReturnType = OSDataType.Text
        )]
        string GetSystemFileName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );
    }
}