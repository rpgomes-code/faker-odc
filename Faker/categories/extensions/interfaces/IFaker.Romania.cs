using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Romania-related methods for the IFaker interface.
    /// This partial interface contains all Romania-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Romania Methods

        [OSAction(
            Description = "Gets a Romanian Personal Identification Number (CNP) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "RomaniaCnp",
            ReturnType = OSDataType.Text
        )]
        string GetRomania_Person_Cnp(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}