using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Italy-related methods for the IFaker interface.
    /// This partial interface contains all Italy-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Italy Methods

        [OSAction(
            Description = "Gets an Italian Codice Fiscale (tax code) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ItalyCodiceFiscale",
            ReturnType = OSDataType.Text
        )]
        string GetItaly_Person_CodiceFiscale(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}