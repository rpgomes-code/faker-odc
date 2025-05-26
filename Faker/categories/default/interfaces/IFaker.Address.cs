using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Address-related methods for the IFaker interface.
    /// This partial interface contains all address generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Address Methods

        [OSAction(
            Description = "Gets a random zip code based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ZipCode",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_ZipCode(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random city based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "City",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_City(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random street address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StreetAddress",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_StreetAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random city prefix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CityPrefix",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_CityPrefix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random city suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CitySuffix",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_CitySuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random street name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StreetName",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_StreetName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random building number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BuildingNumber",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_BuildingNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random street suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StreetSuffix",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_StreetSuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random secondary address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "SecondaryAddress",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_SecondaryAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random county based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "County",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_County(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random country based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Country",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_Country(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random full address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FullAddress",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_FullAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random country code based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CountryCode",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_CountryCode(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random state based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "State",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_State(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random state abbreviation based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "StateAbbreviation",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_StateAbbreviation(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random latitude based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Latitude",
            ReturnType = OSDataType.Decimal
        )]
        double GetAddress_Latitude(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random longitude based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Longitude",
            ReturnType = OSDataType.Decimal
        )]
        double GetAddress_Longitude(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random direction based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Direction",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_Direction(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random cardinal direction based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CardinalDirection",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_CardinalDirection(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random ordinal direction based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "OrdinalDirection",
            ReturnType = OSDataType.Text
        )]
        string GetAddress_OrdinalDirection(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}