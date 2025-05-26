namespace Faker
{
    /// <summary>
    /// Commerce-related methods for the Faker class.
    /// This partial class contains all commerce and product generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Commerce Methods

        /// <summary>
        /// Generates a random department based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random department.</returns>
        public string GetCommerce_Department(string language)
        {
            return CreateFaker(language).Commerce.Department();
        }

        /// <summary>
        /// Generates a random price based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random price.</returns>
        public string GetCommerce_Price(string language)
        {
            return CreateFaker(language).Commerce.Price();
        }

        /// <summary>
        /// Generates a random categories based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random categories.</returns>
        public string[] GetCommerce_Categories(string language, int count)
        {
            return CreateFaker(language).Commerce.Categories(count);
        }

        /// <summary>
        /// Generates a random product name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random product name.</returns>
        public string GetCommerce_ProductName(string language)
        {
            return CreateFaker(language).Commerce.ProductName();
        }

        /// <summary>
        /// Generates a random color based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random color.</returns>
        public string GetCommerce_Color(string language)
        {
            return CreateFaker(language).Commerce.Color();
        }

        /// <summary>
        /// Generates a random product based on the provided language code.
        /// This method combines adjective, material, and product name.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random product description.</returns>
        public string GetCommerce_Product(string language)
        {
            return CreateFaker(language).Commerce.Product();
        }

        /// <summary>
        /// Generates a random product adjective based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random product adjective.</returns>
        public string GetCommerce_ProductAdjective(string language)
        {
            return CreateFaker(language).Commerce.ProductAdjective();
        }

        /// <summary>
        /// Generates a random product material based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random product material.</returns>
        public string GetCommerce_ProductMaterial(string language)
        {
            return CreateFaker(language).Commerce.ProductMaterial();
        }

        /// <summary>
        /// Generates a random Ean8 based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Ean8.</returns>
        public string GetCommerce_Ean8(string language)
        {
            return CreateFaker(language).Commerce.Ean8();
        }

        /// <summary>
        /// Generates a random Ean13 based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Ean13.</returns>
        public string GetCommerce_Ean13(string language)
        {
            return CreateFaker(language).Commerce.Ean13();
        }

        #endregion
    }
}