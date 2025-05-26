using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Image-related methods for the IFaker interface.
    /// This partial interface contains all image generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Image Methods

        [OSAction(
            Description = "Gets a random SVG data URI image with specific dimensions based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DataUri",
            ReturnType = OSDataType.Text
        )]
        string GetImage_DataUri(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.Integer,
                Description = "Image width in pixels"
            )]
            int width,
            [OSParameter(
                DataType = OSDataType.Integer,
                Description = "Image height in pixels"
            )]
            int length
        );

        [OSAction(
            Description = "Gets a random image URL from Picsum service based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PicsumUrl",
            ReturnType = OSDataType.Text
        )]
        string GetImage_PicsumUrl(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random placeholder image URL with specific dimensions based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PlaceholderUrl",
            ReturnType = OSDataType.Text
        )]
        string GetImage_PlaceholderUrl(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.Integer,
                Description = "Image width in pixels"
            )]
            int width,
            [OSParameter(
                DataType = OSDataType.Integer,
                Description = "Image height in pixels"
            )]
            int length
        );

        [OSAction(
            Description = "Gets a random image URL from Lorem Flickr service based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LoremFlickrUrl",
            ReturnType = OSDataType.Text
        )]
        string GetImage_LoremFlickrUrl(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}