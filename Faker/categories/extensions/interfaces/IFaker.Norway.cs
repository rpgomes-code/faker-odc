using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Norway-related methods for the IFaker interface.
    /// This partial interface contains all Norway-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Norway Methods

        [OSAction(
            Description = "Gets a Norwegian National Identity Number (Fødselsnummer) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "NorwayFodselsnummer",
            ReturnType = OSDataType.Text
        )]
        string GetNorway_Person_Fodselsnummer(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}