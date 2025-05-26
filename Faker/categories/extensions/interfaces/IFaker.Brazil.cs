using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Brazil-related methods for the IFaker interface.
    /// This partial interface contains all Brazil-specific generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Brazil Methods

        [OSAction(
            Description = "Gets a Brazilian CPF (Cadastro de Pessoas Físicas) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BrazilCpf",
            ReturnType = OSDataType.Text
        )]
        string GetBrazil_Person_Cpf(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a Brazilian CNPJ (Cadastro Nacional da Pessoa Jurídica) based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BrazilCnpj",
            ReturnType = OSDataType.Text
        )]
        string GetBrazil_Company_Cnpj(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}