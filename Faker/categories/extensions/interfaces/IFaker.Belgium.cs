using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Belgium-related methods for the IFaker interface.
    /// This partial interface contains all Belgium-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Belgium Methods

        [OSAction(
            Description = "Gets a Belgian National Number (Rijksregisternummer / Numéro Nationale) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BelgiumNationalNumber",
            ReturnType = OSDataType.Text
        )]
        string GetBelgium_Person_NationalNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}