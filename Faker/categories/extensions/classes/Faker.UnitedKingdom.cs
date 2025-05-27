using Bogus.Extensions.UnitedKingdom;

namespace Faker
{
    /// <summary>
    /// United Kingdom-related methods for the Faker class.
    /// This partial class contains all United Kingdom generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region UnitedKingdom Methods

        /// <summary>
        /// Generates a random United Kingdom vehicle registration plate based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random United Kingdom vehicle registration plate.</returns>
        public string GetUnitedKingdom_Vehicle_GbRegistrationPlate(string language, DateTime startDate, DateTime endDate)
        {
            return CreateFaker(language).Vehicle.GbRegistrationPlate(startDate, endDate);
        }

        /// <summary>
        /// Generates a random United Kingdom banking sort code based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random United Kingdom banking sort code.</returns>
        public string GetUnitedKingdom_Finance_SortCode(string language)
        {
            return CreateFaker(language).Finance.SortCode();
        }

        /// <summary>
        /// Generates a random United Kingdom national insurance number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random United Kingdom national insurance number.</returns>
        public string GetUnitedKingdom_Finance_Nino(string language)
        {
            return CreateFaker(language).Finance.Nino();
        }

        /// <summary>
        /// Generates a random United Kingdom VAT registration number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <param name="vatType">VAT registration number type (0=Standard, 1=Branch, 2=Group, 3=Partnership, 4=NonProfit)</param>
        /// <returns>A random United Kingdom VAT registration number.</returns>
        public string GetUnitedKingdom_Finance_VatNumber(string language)
        {
            return CreateFaker(language).Finance.VatNumber(VatRegistrationNumberType.Standard);
        }

        /// <summary>
        /// Generates a random country of the United Kingdom based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random country of the United Kingdom.</returns>
        public string GetUnitedKingdom_Address_CountryOfUnitedKingdom(string language)
        {
            return CreateFaker(language).Address.CountryOfUnitedKingdom();
        }

        #endregion
    }
}