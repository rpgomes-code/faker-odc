using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Name-related methods for the IFaker interface.
    /// This partial interface contains all name generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Name Methods

        [OSAction(
            Description = "Gets a random first name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FirstName",
            ReturnType = OSDataType.Text
        )]
        string GetName_FirstName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'fr', 'de')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random last name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LastName",
            ReturnType = OSDataType.Text
        )]
        string GetName_LastName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'it')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random full name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FullName",
            ReturnType = OSDataType.Text
        )]
        string GetName_FullName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random name prefix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "NamePrefix",
            ReturnType = OSDataType.Text
        )]
        string GetName_NamePrefix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random name suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "NameSuffix",
            ReturnType = OSDataType.Text
        )]
        string GetName_NameSuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random full name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FindName",
            ReturnType = OSDataType.Text
        )]
        string GetName_FindName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random job title based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobTitle",
            ReturnType = OSDataType.Text
        )]
        string GetName_JobTitle(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random job descriptor based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobDescription",
            ReturnType = OSDataType.Text
        )]
        string GetName_JobDescriptor(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random job area based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobArea",
            ReturnType = OSDataType.Text
        )]
        string GetName_JobArea(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random job type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobType",
            ReturnType = OSDataType.Text
        )]
        string GetName_JobType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}