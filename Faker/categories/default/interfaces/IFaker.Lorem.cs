using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Lorem-related methods for the IFaker interface.
    /// This partial interface contains all lorem generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Lorem Methods

        [OSAction(
            Description = "Gets a random lorem word based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremWord",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Word(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets random lorem words based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremWords",
            ReturnType = OSDataType.Text
        )]
        string[] GetLorem_Words(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random lorem letter based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremLetter",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Letter(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random lorem sentence based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremSentence",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Sentence(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets random lorem sentences based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremSentences",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Sentences(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random lorem paragraph based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremParagraph",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Paragraph(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets random lorem paragraphs based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremParagraphs",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Paragraphs(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets random lorem text based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremText",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Text(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets random lorem lines based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremLines",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Lines(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random lorem slug based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremSlug",
            ReturnType = OSDataType.Text
        )]
        string GetLorem_Slug(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}