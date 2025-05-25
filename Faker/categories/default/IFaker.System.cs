using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// System-related methods for the IFaker interface.
    /// This partial interface contains all system generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region System Methods

        [OSAction(
            Description = "Gets a random file name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "SystemFileName",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_FileName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}