using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Sweden-related methods for the IFaker interface.
    /// This partial interface contains all Sweden-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Sweden Methods

        [OSAction(
            Description = "Gets a Swedish National Identity Number (Personnummer) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "SwedenPersonnummer",
            ReturnType = OSDataType.Text
        )]
        string GetSweden_Person_Personnummer(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a Swedish Coordination Number (Samordningsnummer) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "SwedenSamordningsnummer",
            ReturnType = OSDataType.Text
        )]
        string GetSweden_Person_Samordningsnummer(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}