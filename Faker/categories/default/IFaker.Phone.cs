using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Phone-related methods for the IFaker interface.
    /// This partial interface contains all phone generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Phone Methods

        [OSAction(
            Description = "Gets a random phone number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PhoneNumber",
            ReturnType = OSDataType.Text
        )]
        string GetPhone_PhoneNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random phone number formatted based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PhoneNumberFormated",
            ReturnType = OSDataType.Text
        )]
        string GetPhone_PhoneNumberFormat(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}