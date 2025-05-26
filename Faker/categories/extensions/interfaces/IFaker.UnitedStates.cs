using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// United States-related methods for the IFaker interface.
    /// This partial interface contains all United States-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region United States Methods

        [OSAction(
            Description = "Gets a US Social Security Number (SSN) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "USSsn",
            ReturnType = OSDataType.Text
        )]
        string GetUnitedStates_Person_Ssn(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a US Employer Identification Number (EIN) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "USEin",
            ReturnType = OSDataType.Text
        )]
        string GetUnitedStates_Company_Ein(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}