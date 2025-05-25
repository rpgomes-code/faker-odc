using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Database-related methods for the IFaker interface.
    /// This partial interface contains all database generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Database Methods

        [OSAction(
            Description = "Gets a random database column name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Column",
            ReturnType = OSDataType.Text
        )]
        string GetDatabase_Column(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random database type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Type",
            ReturnType = OSDataType.Text
        )]
        string GetDatabase_Type(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random database collation based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Collation",
            ReturnType = OSDataType.Text
        )]
        string GetDatabase_Collation(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random database engine based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Engine",
            ReturnType = OSDataType.Text
        )]
        string GetDatabase_Engine(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}