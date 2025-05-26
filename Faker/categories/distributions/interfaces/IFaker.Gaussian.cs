using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Gaussian distribution-related methods for the IFaker interface.
    /// This partial interface contains all Gaussian distribution generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Gaussian Methods

        [OSAction(
            Description = "Gets a random Gaussian-distributed integer based on a provided language code, mean, and standard deviation",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "GaussianInt",
            ReturnType = OSDataType.Decimal
        )]
        double GetGaussian_Random_GaussianInt(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Mean value for the Gaussian distribution"
            )]
            double mean,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Standard deviation for the Gaussian distribution"
            )]
            double deviation
        );

        [OSAction(
            Description = "Gets a random Gaussian-distributed float based on a provided language code, mean, and standard deviation",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "GaussianFloat",
            ReturnType = OSDataType.Decimal
        )]
        double GetGaussian_Random_GaussianFloat(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Mean value for the Gaussian distribution"
            )]
            double mean,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Standard deviation for the Gaussian distribution"
            )]
            double deviation
        );

        [OSAction(
            Description = "Gets a random Gaussian-distributed double based on a provided language code, mean, and standard deviation",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "GaussianDouble",
            ReturnType = OSDataType.Decimal
        )]
        double GetGaussian_Random_GaussianDouble(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Mean value for the Gaussian distribution"
            )]
            double mean,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Standard deviation for the Gaussian distribution"
            )]
            double deviation
        );

        [OSAction(
            Description = "Gets a random Gaussian-distributed decimal based on a provided language code, mean, and standard deviation",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "GaussianDecimal",
            ReturnType = OSDataType.Decimal
        )]
        decimal GetGaussian_Random_GaussianDecimal(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Mean value for the Gaussian distribution"
            )]
            double mean,
            [OSParameter(
                DataType = OSDataType.Decimal,
                Description = "Standard deviation for the Gaussian distribution"
            )]
            double deviation
        );

        #endregion
    }
}