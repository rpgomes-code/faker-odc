using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Company-related methods for the IFaker interface.
    /// This partial interface contains all company generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Company Methods

        [OSAction(
            Description = "Gets a random company suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CompanySuffix",
            ReturnType = OSDataType.Text
        )]
        string GetCompany_CompanySuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random company name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CompanyName",
            ReturnType = OSDataType.Text
        )]
        string GetCompany_CompanyName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random company catch phrase based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CatchPhrase",
            ReturnType = OSDataType.Text
        )]
        string GetCompany_CatchPhrase(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random company BS phrase based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CompanyBs",
            ReturnType = OSDataType.Text
        )]
        string GetCompany_Bs(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}