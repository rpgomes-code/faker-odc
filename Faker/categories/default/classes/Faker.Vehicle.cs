namespace Faker
{
    /// <summary>
    /// Vehicle-related methods for the Faker class.
    /// This partial class contains all vehicle generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Vehicle Methods

        /// <summary>
        /// Generates a random vehicle vin based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random vehicle vin.</returns>
        public string GetVehicle_Vin(string language)
        {
            return CreateFaker(language).Vehicle.Vin();
        }

        /// <summary>
        /// Generates a random vehicle manufacturer based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random vehicle manufacturer.</returns>
        public string GetVehicle_Manufacturer(string language)
        {
            return CreateFaker(language).Vehicle.Manufacturer();
        }

        /// <summary>
        /// Generates a random vehicle model based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random vehicle model.</returns>
        public string GetVehicle_Model(string language)
        {
            return CreateFaker(language).Vehicle.Model();
        }

        /// <summary>
        /// Generates a random vehicle type based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random vehicle type.</returns>
        public string GetVehicle_Type(string language)
        {
            return CreateFaker(language).Vehicle.Type();
        }

        /// <summary>
        /// Generates a random vehicle fuel based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random vehicle fuel.</returns>
        public string GetVehicle_Fuel(string language)
        {
            return CreateFaker(language).Vehicle.Fuel();
        }

        #endregion
    }
}