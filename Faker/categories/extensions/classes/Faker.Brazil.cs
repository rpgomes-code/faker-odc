using Bogus.Extensions.Brazil;

namespace Faker
{
    /// <summary>
    /// Brazil-related methods for the Faker class.
    /// This partial class contains all Brazil generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Brazil Methods

        /// <summary>
        /// Generates a random Brazil cpf based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Brazil cpf.</returns>
        public string GetBrazil_Person_Cpf(string language)
        {
            return CreateFaker(language).Person.Cpf();
        }

        /// <summary>
        /// Generates a random Brazil cnpj based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random Brazil cnpj.</returns>
        public string GetBrazil_Company_Cnpj(string language)
        {
            return CreateFaker(language).Company.Cnpj();
        }

        #endregion
    }
}