using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Poland-related methods for the IFaker interface.
    /// This partial interface contains all Poland-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Poland Methods

        [OSAction(
            Description = "Gets a Polish PESEL (Powszechny Elektroniczny System Ewidencji Ludności) number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PolandPesel",
            ReturnType = OSDataType.Text
        )]
        string GetPoland_Person_Pesel(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a Polish NIP (Numer Identyfikacji Podatkowej) number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PolandNip",
            ReturnType = OSDataType.Text
        )]
        string GetPoland_Company_Nip(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a Polish REGON (Rejestr Gospodarki Narodowej) number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PolandRegon",
            ReturnType = OSDataType.Text
        )]
        string GetPoland_Company_Regon(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}