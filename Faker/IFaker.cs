using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// The IFaker interface defines methods for generating realistic fake/demo data
    /// such as names, emails, phone numbers, addresses, and job titles with multilingual support.
    /// </summary>
    [OSInterface(
        Name = "Faker",
        Description = "A utility library for generating realistic fake/demo data such as names, emails, phone numbers, addresses, job titles, and internet-related data. Useful for testing, prototyping, and seeding applications with multilingual support.",
        IconResourceName = "Faker.resources.Logo.png"
    )]
    public interface IFaker
    {
        // Name related methods
        /// <summary>
        /// Gets a random full name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random full name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FullName",
            ReturnType = OSDataType.Text
        )]
        string GetFullName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random first name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random first name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FirstName",
            ReturnType = OSDataType.Text
        )]
        string GetFirstName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'fr', 'de')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random last name based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random last name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "LastName",
            ReturnType = OSDataType.Text
        )]
        string GetLastName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'it')"
            )]
            string language
        );

        // Job related methods
        /// <summary>
        /// Gets a random job area based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job area based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobArea",
            ReturnType = OSDataType.Text
        )]
        string GetJobArea(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random job type based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobType",
            ReturnType = OSDataType.Text
        )]
        string GetJobType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random job title based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job title based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobTitle",
            ReturnType = OSDataType.Text
        )]
        string GetJobTitle(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random job descriptor based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random job descriptor based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "JobDescription",
            ReturnType = OSDataType.Text
        )]
        string GetJobDescriptor(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Phone related methods
        /// <summary>
        /// Gets a random phone number based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random phone number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PhoneNumber",
            ReturnType = OSDataType.Text
        )]
        string GetPhoneNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Internet related methods
        /// <summary>
        /// Gets a random email address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random email address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Email",
            ReturnType = OSDataType.Text
        )]
        string GetEmail(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random IPv4 address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random IPv4 address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IPv4Address",
            ReturnType = OSDataType.Text
        )]
        string GetIP(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random IPv6 address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random IPv6 address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IPv6Address",
            ReturnType = OSDataType.Text
        )]
        string GetIPv6(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random MAC address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random MAC address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "MacAddress",
            ReturnType = OSDataType.Text
        )]
        string GetMac(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random password based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random password based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Password",
            ReturnType = OSDataType.Text
        )]
        string GetPassword(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random port number based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random port number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Port",
            ReturnType = OSDataType.Integer
        )]
        int GetPort(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random username based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random username based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Username",
            ReturnType = OSDataType.Text
        )]
        string GetUserName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random protocol based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random protocol based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Protocol",
            ReturnType = OSDataType.Text
        )]
        string GetProtocol(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random URL based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random URL based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Url",
            ReturnType = OSDataType.Text
        )]
        string GetUrl(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        // Address related methods
        /// <summary>
        /// Gets a random full address based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random full address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FullAddress",
            ReturnType = OSDataType.Text
        )]
        string GetFullAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random city based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random city based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "City",
            ReturnType = OSDataType.Text
        )]
        string GetCity(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random country based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random country based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Country",
            ReturnType = OSDataType.Text
        )]
        string GetCountry(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        /// <summary>
        /// Gets a random state based on the provided language code.
        /// This method is exposed as a server action to your ODC apps and libraries.
        /// </summary>
        [OSAction(
            Description = "Gets a random state based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "State",
            ReturnType = OSDataType.Text
        )]
        string GetState(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );
    }
}