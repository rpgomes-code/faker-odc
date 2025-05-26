using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Canada-related methods for the IFaker interface.
    /// This partial interface contains all Canada-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Canada Methods

        [OSAction(
            Description = "Gets a Canadian Social Insurance Number (SIN) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CanadaSin",
            ReturnType = OSDataType.Text
        )]
        string GetCanada_Person_Sin(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}