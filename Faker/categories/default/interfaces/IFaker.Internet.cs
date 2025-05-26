using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Internet-related methods for the IFaker interface.
    /// This partial interface contains all internet generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Internet Methods

        [OSAction(
            Description = "Gets a random avatar URL based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Avatar",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Avatar(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random email address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Email",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Email(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random example email address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ExampleEmail",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_ExampleEmail(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random username based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Username",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_UserName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random username with unicode characters based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UserNameUnicode",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_UserNameUnicode(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random domain name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DomainName",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_DomainName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random domain word based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DomainWord",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_DomainWord(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random domain suffix based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "DomainSuffix",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_DomainSuffix(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random IPv4 address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IPv4Address",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Ip(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random port number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Port",
            ReturnType = OSDataType.Integer
        )]
        int GetInternet_Port(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random IPv6 address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IPv6Address",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Ipv6(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random user agent based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UserAgent",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_UserAgent(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random MAC address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "MacAddress",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Mac(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random password based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Password",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Password(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random internet color based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "InternetColor",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Color(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random protocol based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Protocol",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Protocol(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random URL based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Url",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_Url(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random URL with path based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UrlWithPath",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_UrlWithPath(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random URL rooted path based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "UrlRootedPath",
            ReturnType = OSDataType.Text
        )]
        string GetInternet_UrlRootedPath(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}