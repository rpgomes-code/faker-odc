using Bogus.DataSets;

namespace Faker
{
    /// <summary>
    /// Finance-related methods for the Faker class.
    /// This partial class contains all finance generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Finance Methods

        /// <summary>
        /// Generates a random account based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random account.</returns>
        public string GetFinance_Account(string language)
        {
            return CreateFaker(language).Finance.Account();
        }

        /// <summary>
        /// Generates a random account name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random account name.</returns>
        public string GetFinance_AccountName(string language)
        {
            return CreateFaker(language).Finance.AccountName();
        }

        /// <summary>
        /// Generates a random finance amount based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random finance amount.</returns>
        public decimal GetFinance_Amount(string language)
        {
            return CreateFaker(language).Finance.Amount();
        }

        /// <summary>
        /// Generates a random financial transaction type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random financial transaction type.</returns>
        public string GetFinance_TransactionType(string language)
        {
            return CreateFaker(language).Finance.TransactionType();
        }

        /// <summary>
        /// Generates a random currency code based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random currency code.</returns>
        public string GetFinance_Currency(string language)
        {
            var currency = CreateFaker(language).Finance.Currency();
            return currency.Code; // Return just the currency code (e.g., "USD", "EUR", "GBP")
        }

        /// <summary>
        /// Generates a random credit card number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random credit card number.</returns>
        public string GetFinance_CreditCardNumber(string language)
        {
            return CreateFaker(language).Finance.CreditCardNumber();
        }

        /// <summary>
        /// Generates a random credit card CVV based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random credit card CVV.</returns>
        public string GetFinance_CreditCardCvv(string language)
        {
            return CreateFaker(language).Finance.CreditCardCvv();
        }

        /// <summary>
        /// Generates a random bitcoin address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random bitcoin address.</returns>
        public string GetFinance_BitcoinAddress(string language)
        {
            return CreateFaker(language).Finance.BitcoinAddress();
        }

        /// <summary>
        /// Generates a random ethereum address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random ethereum address.</returns>
        public string GetFinance_EthereumAddress(string language)
        {
            return CreateFaker(language).Finance.EthereumAddress();
        }

        /// <summary>
        /// Generates a random financial routing number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random financial routing number.</returns>
        public string GetFinance_RoutingNumber(string language)
        {
            return CreateFaker(language).Finance.RoutingNumber();
        }

        /// <summary>
        /// Generates a random account BIC based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random account BIC.</returns>
        public string GetFinance_Bic(string language)
        {
            return CreateFaker(language).Finance.Bic();
        }

        /// <summary>
        /// Generates a random account IBAN based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random account IBAN.</returns>
        public string GetFinance_Iban(string language)
        {
            return CreateFaker(language).Finance.Iban();
        }

        #endregion
    }
}