using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Portugal-related methods for the IFaker interface.
    /// This partial interface contains all Portugal-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Portugal Methods

        [OSAction(
            Description = "Gets a Portuguese NIF (Número de Identificação Fiscal) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PortugalNif",
            ReturnType = OSDataType.Text
        )]
        string GetPortugal_Person_Nif(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a Portuguese NIPC (Número de Identificação de Pessoa Colectiva) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PortugalNipc",
            ReturnType = OSDataType.Text
        )]
        string GetPortugal_Person_Nipc(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}