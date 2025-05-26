using Bogus.Distributions.Gaussian;

namespace Faker
{
    /// <summary>
    /// Gaussian-related methods for the Faker class.
    /// This partial class contains all Gaussian generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Gaussian Methods

        /// <summary>
        /// Generates a random gaussian integer based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random gaussian integer.</returns>
        public double GetGaussian_Random_GaussianInt(string language, double mean, double deviation)
        {
            return CreateFaker(language).Random.GaussianInt(mean, deviation);
        }

        /// <summary>
        /// Generates a random gaussian float based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random gaussian float.</returns>
        public double GetGaussian_Random_GaussianFloat(string language, double mean, double deviation)
        {
            return CreateFaker(language).Random.GaussianFloat(mean, deviation);
        }

        /// <summary>
        /// Generates a random gaussian double based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random gaussian double.</returns>
        public double GetGaussian_Random_GaussianDouble(string language, double mean, double deviation)
        {
            return CreateFaker(language).Random.GaussianDouble(mean, deviation);
        }

        /// <summary>
        /// Generates a random gaussian decimal based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random gaussian decimal.</returns>
        public decimal GetGaussian_Random_GaussianDecimal(string language, double mean, double deviation)
        {
            return CreateFaker(language).Random.GaussianDecimal(mean, deviation);
        }

        #endregion
    }
}