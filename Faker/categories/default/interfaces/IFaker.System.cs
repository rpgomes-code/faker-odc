using System;
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

        [OSAction(
            Description = "Gets a random directory path based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DirectoryPath",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_DirectoryPath(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random file path based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FilePath",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_FilePath(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random common file name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CommonFileName",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_CommonFileName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random MIME type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "MimeType",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_MimeType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random common file type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CommonFileType",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_CommonFileType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random common file extension based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CommonFileExt",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_CommonFileExt(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random file type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FileType",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_FileType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random file extension based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FileExt",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_FileExt(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random semantic version based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Semver",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_Semver(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random version based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Version",
            ReturnType = OSDataType.Text
        )]
        Version GetSystem_Version(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random exception based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Exception",
            ReturnType = OSDataType.Text
        )]
        Exception GetSystem_Exception(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random Android ID based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "AndroidId",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_AndroidId(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random Apple push token based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ApplePushToken",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_ApplePushToken(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random BlackBerry PIN based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BlackBerryPin",
            ReturnType = OSDataType.Text
        )]
        string GetSystem_BlackBerryPin(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}