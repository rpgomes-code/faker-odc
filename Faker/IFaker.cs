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
    public partial interface IFaker
    {
        // This is the main interface file.
        // All method definitions are in the partial interface files
        // located in the same namespace.
    }
}