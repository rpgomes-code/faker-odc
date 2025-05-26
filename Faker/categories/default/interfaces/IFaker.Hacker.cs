using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Hacker-related methods for the IFaker interface.
    /// This partial interface contains all hacker generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Hacker Methods

        [OSAction(
            Description = "Gets a random hacker abbreviation based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerAbbreviation",
            ReturnType = OSDataType.Text
        )]
        string GetHacker_Abbreviation(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random hacker adjective based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerAdjective",
            ReturnType = OSDataType.Text
        )]
        string GetHacker_Adjective(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random hacker noun based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerNoun",
            ReturnType = OSDataType.Text
        )]
        string GetHacker_Noun(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random hacker verb based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerVerb",
            ReturnType = OSDataType.Text
        )]
        string GetHacker_Verb(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random hacker verb ending with -ing based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerIngVerb",
            ReturnType = OSDataType.Text
        )]
        string GetHacker_IngVerb(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random hacker phrase based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "HackerPhrase",
            ReturnType = OSDataType.Text
        )]
        string GetHacker_Phrase(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}