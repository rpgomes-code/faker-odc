using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Vehicle-related methods for the IFaker interface.
    /// This partial interface contains all vehicle generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Vehicle Methods

        [OSAction(
            Description = "Gets a random vehicle VIN based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "VehicleVIN",
            ReturnType = OSDataType.Text
        )]
        string GetVehicle_Vin(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random vehicle manufacturer based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "VehicleManufacturer",
            ReturnType = OSDataType.Text
        )]
        string GetVehicle_Manufacturer(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random vehicle model based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "VehicleModel",
            ReturnType = OSDataType.Text
        )]
        string GetVehicle_Model(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random vehicle type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "VehicleType",
            ReturnType = OSDataType.Text
        )]
        string GetVehicle_Type(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random vehicle fuel type based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "VehicleFuel",
            ReturnType = OSDataType.Text
        )]
        string GetVehicle_Fuel(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}