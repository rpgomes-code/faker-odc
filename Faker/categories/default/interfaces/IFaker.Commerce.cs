using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Commerce-related methods for the IFaker interface.
    /// This partial interface contains all commerce and product generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Commerce Methods

        [OSAction(
            Description = "Gets a random department based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Department",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_Department(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random price based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Price",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_Price(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets random product categories based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Categories",
            ReturnType = OSDataType.Text
        )]
        string[] GetCommerce_Categories(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.Integer,
                Description = "Number of categories to generate"
            )]
            int count
        );

        [OSAction(
            Description = "Gets a random product name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ProductName",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_ProductName(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random color based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Color",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_Color(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random product description based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Product",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_Product(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random product adjective based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ProductAdjective",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_ProductAdjective(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random product material based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "ProductMaterial",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_ProductMaterial(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random EAN-8 barcode number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Ean8",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_Ean8(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random EAN-13 barcode number based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Ean13",
            ReturnType = OSDataType.Text
        )]
        string GetCommerce_Ean13(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}