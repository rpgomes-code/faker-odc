using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Rant-related methods for the IFaker interface.
    /// This partial interface contains all rant generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Rant Methods

        [OSAction(
            Description = "Gets a random review based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "RantReview",
            ReturnType = OSDataType.Text
        )]
        string GetRant_Review(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}