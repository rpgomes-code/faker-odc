using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Denmark-related methods for the IFaker interface.
    /// This partial interface contains all Denmark-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Denmark Methods

        [OSAction(
            Description = "Gets a Danish Personal Identification Number (CPR) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DenmarkCpr",
            ReturnType = OSDataType.Text
        )]
        string GetDenmark_Person_Cpr(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}