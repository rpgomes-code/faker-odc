using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Finland-related methods for the IFaker interface.
    /// This partial interface contains all Finland-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Finland Methods

        [OSAction(
            Description = "Gets a Finnish Henkilötunnus (personal identity code) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FinlandHenkilotunnus",
            ReturnType = OSDataType.Text
        )]
        string GetFinland_Person_Henkilotunnus(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}