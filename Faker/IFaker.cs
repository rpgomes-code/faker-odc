using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    [OSInterface(
    Name = "Faker",
    IconResourceName = "Faker.Logo.png",
    Description = "A utility library for generating realistic fake/demo data such as names, emails, phone numbers, addresses, job titles, and internet-related data. Useful for testing, prototyping, and seeding applications with multilingual support. Supports localized data for various language codes."
)]
    public interface IFaker
    {
        // Name related
        [OSAction(Description = "Gets a random full name based on a provided language code.")]
        void GetFullName([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Random full name (ex: 'John Doe', 'João Pessoa', ...)")] out string name);

        [OSAction(Description = "Gets a random first name based on a provided language code.")]
        void GetFirstName([OSParameter(Description = "Language code (ex: 'en', 'fr', 'de',...)")] string language, [OSParameter(Description = "Random first name (ex: 'Alice', 'Carlos', ...)")] out string firstname);

        [OSAction(Description = "Gets a random last name based on a provided language code.")]
        void GetLastName([OSParameter(Description = "Language code (ex: 'en', 'es', 'it', ...)")] string language, [OSParameter(Description = "Random last name (ex: 'Smith', 'García', ...)")] out string lastname);

        [OSAction(Description = "Gets a random job area based on a provided language code.")]
        void GetJobArea([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Job area (ex: 'Marketing', 'Engineering', ...)")] out string jobarea);

        [OSAction(Description = "Gets a random job type based on a provided language code.")]
        void GetJobType([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Job type (ex: 'Full-time', 'Contract', ...)")] out string jobtype);

        [OSAction(Description = "Gets a random job title based on a provided language code.")]
        void GetJobTitle([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Job title (ex: 'Software Engineer', 'Project Manager', ...)")] out string jobtitle);

        [OSAction(Description = "Gets a random job descriptor based on a provided language code.")]
        void GetJobDescription([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Job description (ex: 'Lead', 'Senior', ...)")] out string jobdescription);

        // Phone related
        [OSAction(Description = "Gets a random phone number based on a provided language code.")]
        void GetPhoneNumber([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Phone number (ex: '+1 555-1234')")] out string phone);

        // Internet related
        [OSAction(Description = "Gets a random email address based on a provided language code.")]
        void GetEmail([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Email address (ex: 'johndoe@example.com')")] out string email);

        [OSAction(Description = "Gets a random IPv4 address based on a provided language code.")]
        void GetIPv4([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "IPv4 address (ex: '192.168.1.1')")] out string ipv4);

        [OSAction(Description = "Gets a random IPv6 address based on a provided language code.")]
        void GetIPv6([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "IPv6 address (ex: '2001:0db8:85a3:0000:0000:8a2e:0370:7334')")] out string ipv6);

        [OSAction(Description = "Gets a random MAC address based on a provided language code.")]
        void GetMac([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "MAC address (ex: '00:1B:44:11:3A:B7')")] out string mac);

        [OSAction(Description = "Gets a random password based on a provided language code.")]
        void GetPassword([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Random password (ex: 'XyZ123!@#')")] out string password);

        [OSAction(Description = "Gets a random port number based on a provided language code.")]
        void GetPort([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Random port number (ex: 8080)")] out int port);

        [OSAction(Description = "Gets a random username based on a provided language code.")]
        void GetUserName([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Username (ex: 'johndoe87')")] out string username);

        [OSAction(Description = "Gets a random protocol based on a provided language code.")]
        void GetProtocol([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Protocol (ex: 'http', 'ftp')")] out string protocol);

        [OSAction(Description = "Gets a random URL based on a provided language code.")]
        void GetUrl([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "URL (ex: 'https://example.com')")] out string url);

        // Address related
        [OSAction(Description = "Gets a random full address based on a provided language code.")]
        void GetFullAddress([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Full address (ex: '123 Main St, Springfield')")] out string address);

        [OSAction(Description = "Gets a random city based on a provided language code.")]
        void GetCity([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "City name (ex: 'Paris')")] out string city);

        [OSAction(Description = "Gets a random country based on a provided language code.")]
        void GetCountry([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "Country name (ex: 'France')")] out string country);

        [OSAction(Description = "Gets a random state based on a provided language code.")]
        void GetState([OSParameter(Description = "Language code (ex: 'en', 'es', 'pt_PT',...)")] string language, [OSParameter(Description = "State or region name (ex: 'California')")] out string state);
    }
}
