using System;
using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// United Kingdom-related methods for the IFaker interface.
    /// This partial interface contains all United Kingdom-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region United Kingdom Methods

        [OSAction(
            Description = "Gets a UK vehicle registration plate for a specific date range based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UKRegistrationPlate",
            ReturnType = OSDataType.Text
        )]
        string GetUnitedKingdom_Vehicle_GbRegistrationPlate(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.DateTime,
                Description = "Start date for registration period"
            )]
            DateTime startDate,
            [OSParameter(
                DataType = OSDataType.DateTime,
                Description = "End date for registration period"
            )]
            DateTime endDate
        );

        [OSAction(
            Description = "Gets a UK banking sort code based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UKSortCode",
            ReturnType = OSDataType.Text
        )]
        string GetUnitedKingdom_Finance_SortCode(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a UK National Insurance Number (NINO) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UKNino",
            ReturnType = OSDataType.Text
        )]
        string GetUnitedKingdom_Finance_Nino(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a UK VAT registration number based on a provided language code and type (0=Standard, 1=Branch, 2=Group, 3=Partnership, 4=NonProfit)",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UKVatNumber",
            ReturnType = OSDataType.Text
        )]
        string GetUnitedKingdom_Finance_VatNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random country of the United Kingdom based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UKCountry",
            ReturnType = OSDataType.Text
        )]
        string GetUnitedKingdom_Address_CountryOfUnitedKingdom(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}