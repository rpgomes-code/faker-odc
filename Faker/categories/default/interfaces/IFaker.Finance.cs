using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Finance-related methods for the IFaker interface.
    /// This partial interface contains all finance generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Finance Methods

        [OSAction(
            Description = "Gets a random account number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Account",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_Account(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random account name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "AccountName",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_AccountName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random amount based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Amount",
            ReturnType = OSDataType.Decimal
        )]
        decimal GetFinance_Amount(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random transaction type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "TransactionType",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_TransactionType(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random currency code based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Currency",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_Currency(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random credit card number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CreditCardNumber",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_CreditCardNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random credit card CVV based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "CreditCardCvv",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_CreditCardCvv(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random bitcoin address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BitcoinAddress",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_BitcoinAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random ethereum address based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "EthereumAddress",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_EthereumAddress(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random routing number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "RoutingNumber",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_RoutingNumber(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random BIC code based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BIC",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_Bic(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random IBAN based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "IBAN",
            ReturnType = OSDataType.Text
        )]
        string GetFinance_Iban(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}