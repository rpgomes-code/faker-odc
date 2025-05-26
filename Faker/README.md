# Faker - OutSystems ODC Extension

A powerful OutSystems Developer Cloud (ODC) external library for generating realistic fake/demo data. This extension is a comprehensive wrapper around the popular [Bogus](https://github.com/bchavez/Bogus) .NET library, providing multilingual support for testing, prototyping, and seeding applications with realistic data.

## 🚀 Features

- **Multilingual Support**: Generate data in 40+ languages and locales
- **Comprehensive Data Types**: Names, addresses, emails, phone numbers, companies, products, and much more
- **Country-Specific Extensions**: Support for country-specific data formats (SSN, VAT numbers, etc.)
- **Easy Integration**: Simple server actions ready to use in your ODC applications
- **High Performance**: Built on the proven Bogus library with excellent performance
- **Deterministic**: Supports seeding for reproducible fake data

## 📦 Installation

1. Download the latest release ZIP file
2. Upload to your ODC Portal as an External Library
3. Publish and consume in your ODC applications

## 🌍 Supported Locales

The extension supports the following language codes:

| Locale | Language | | Locale | Language |
|--------|----------|-|--------|----------|
| `af_ZA` | Afrikaans (South Africa) || `fr_CH` | French (Switzerland) |
| `ar` | Arabic || `ge` | Georgian |
| `az` | Azerbaijani || `hr` | Croatian |
| `cz` | Czech || `id_ID` | Indonesian |
| `de` | German || `it` | Italian |
| `de_AT` | German (Austria) || `ja` | Japanese |
| `de_CH` | German (Switzerland) || `ko` | Korean |
| `el` | Greek || `lv` | Latvian |
| `en` | English || `nb_NO` | Norwegian |
| `en_AU` | English (Australia) || `ne` | Nepalese |
| `en_CA` | English (Canada) || `nl` | Dutch |
| `en_GB` | English (Great Britain) || `nl_BE` | Dutch (Belgium) |
| `en_US` | English (United States) || `pl` | Polish |
| `es` | Spanish || `pt_BR` | Portuguese (Brazil) |
| `es_MX` | Spanish (Mexico) || `pt_PT` | Portuguese (Portugal) |
| `fa` | Farsi || `ro` | Romanian |
| `fi` | Finnish || `ru` | Russian |
| `fr` | French || `sk` | Slovakian |
| `fr_CA` | French (Canada) || `sv` | Swedish |

*Default locale is `en` when an invalid or unsupported locale is provided.*

## 📋 Data Categories

### 👤 Name Data
Generate realistic names and job information.

```
// Examples
GetName_FirstName("en")          → "John"
GetName_LastName("en")           → "Doe"
GetName_FullName("en")           → "Jane Smith"
GetName_JobTitle("en")           → "Senior Software Engineer"
GetName_JobArea("en")            → "Technology"
```

### 🏠 Address Data
Generate addresses, locations, and geographic data.

```
// Examples
GetAddress_StreetAddress("en")   → "123 Main Street"
GetAddress_City("en")            → "New York"
GetAddress_State("en")           → "California"
GetAddress_ZipCode("en")         → "90210"
GetAddress_Country("en")         → "United States"
GetAddress_Latitude("en")        → 40.7128
GetAddress_Longitude("en")       → -74.0060
```

### 💼 Company Data
Generate business-related information.

```
// Examples
GetCompany_CompanyName("en")     → "Tech Solutions Inc."
GetCompany_CatchPhrase("en")     → "Innovative solutions for tomorrow"
GetCompany_CompanySuffix("en")   → "LLC"
```

### 🌐 Internet Data
Generate internet-related data like emails, URLs, and IP addresses.

```
// Examples
GetInternet_Email("en")          → "john.doe@example.com"
GetInternet_UserName("en")       → "john_doe_123"
GetInternet_DomainName("en")     → "example.com"
GetInternet_Url("en")            → "https://www.example.com"
GetInternet_Ip("en")             → "192.168.1.100"
GetInternet_Mac("en")            → "AA:BB:CC:DD:EE:FF"
GetInternet_Password("en")       → "SecurePass123!"
```

### 📞 Phone Data
Generate phone numbers in various formats.

```
// Examples
GetPhone_PhoneNumber("en")       → "(555) 123-4567"
GetPhone_PhoneNumberFormat("en") → "555.123.4567"
```

### 🛒 Commerce Data
Generate product and e-commerce related data.

```
// Examples
GetCommerce_ProductName("en")    → "Wireless Headphones"
GetCommerce_Product("en")        → "Ergonomic Steel Keyboard"
GetCommerce_Price("en")          → "$299.99"
GetCommerce_Department("en")     → "Electronics"
GetCommerce_Color("en")          → "Navy Blue"
GetCommerce_Ean13("en")          → "1234567890123"
```

### 💰 Finance Data
Generate financial and banking information.

```
// Examples
GetFinance_Account("en")         → "12345678"
GetFinance_AccountName("en")     → "Savings Account"
GetFinance_Amount("en")          → 1500.50
GetFinance_Currency("en")        → "USD"
GetFinance_CreditCardNumber("en") → "4532-1234-5678-9012"
GetFinance_Iban("en")            → "GB29 NWBK 6016 1331 9268 19"
GetFinance_BitcoinAddress("en")  → "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa"
```

### 📅 Date & Time Data
Generate dates and time-related information.

```
// Examples
GetDate_Past("en")               → 2023-05-15 14:30:25
GetDate_Future("en")             → 2025-08-22 09:15:42
GetDate_Recent("en")             → 2024-01-20 16:45:30
GetDate_Between("en", startDate, endDate) → Date within range
GetDate_Month("en")              → "September"
GetDate_Weekday("en")            → "Monday"
```

### 📝 Lorem Text Data
Generate placeholder text content.

```
// Examples
GetLorem_Word("en")              → "lorem"
GetLorem_Sentence("en")          → "Lorem ipsum dolor sit amet."
GetLorem_Paragraph("en")         → "Lorem ipsum dolor sit amet, consectetur..."
GetLorem_Words("en")             → ["lorem", "ipsum", "dolor"]
```

### 🖼️ Image Data
Generate image URLs and placeholders.

```
// Examples
GetImage_PicsumUrl("en")         → "https://picsum.photos/640/480"
GetImage_PlaceholderUrl("en", 300, 200) → "https://via.placeholder.com/300x200"
GetImage_DataUri("en", 100, 100) → "data:image/svg+xml;base64,..."
```

### 🚗 Vehicle Data
Generate vehicle-related information.

```
// Examples
GetVehicle_Manufacturer("en")    → "Toyota"
GetVehicle_Model("en")           → "Camry"
GetVehicle_Vin("en")             → "1HGBH41JXMN109186"
GetVehicle_Type("en")            → "Sedan"
GetVehicle_Fuel("en")            → "Gasoline"
```

### 💻 System Data
Generate system and technical information.

```
// Examples
GetSystem_FileName("en")         → "document.pdf"
GetSystem_MimeType("en")         → "application/pdf"
GetSystem_Semver("en")           → "1.2.3"
GetSystem_AndroidId("en")        → "APA91bHun4MxP5egoKMwt2KZFBaFUH-THp4"
```

### 🏴󠁧󠁢󠁥󠁮󠁧󠁿 Country-Specific Extensions

#### United States
```
GetUnitedStates_Person_Ssn("en")     → "123-45-6789"
GetUnitedStates_Company_Ein("en")    → "12-3456789"
```

#### United Kingdom
```
GetUnitedKingdom_Finance_SortCode("en")     → "12-34-56"
GetUnitedKingdom_Finance_Nino("en")         → "AB123456C"
GetUnitedKingdom_Finance_VatNumber("en", VatType) → "GB123456789"
```

#### Brazil
```
GetBrazil_Person_Cpf("en")           → "123.456.789-01"
GetBrazil_Company_Cnpj("en")         → "12.345.678/0001-90"
```

#### Germany/Europe
```
GetFinance_Iban("de")                → "DE89370400440532013000"
GetFinance_Bic("de")                 → "COBADEFFXXX"
```

#### And many more countries...
- 🇧🇪 Belgium: National Numbers
- 🇨🇦 Canada: Social Insurance Numbers
- 🇩🇰 Denmark: CPR Numbers
- 🇫🇮 Finland: Henkilötunnus
- 🇮🇹 Italy: Codice Fiscale
- 🇳🇴 Norway: Fødselsnummer
- 🇵🇱 Poland: PESEL, NIP, REGON
- 🇵🇹 Portugal: NIF, NIPC
- 🇷🇴 Romania: CNP
- 🇸🇪 Sweden: Personnummer

## 🎯 Use Cases

### 1. Database Seeding
Perfect for populating development and test databases with realistic data.

### 2. UI Prototyping
Create realistic prototypes with proper-looking data instead of "Lorem ipsum".

### 3. Load Testing
Generate large volumes of test data for performance testing.

### 4. Demo Applications
Build impressive demos with realistic, varied data.

### 5. User Acceptance Testing
Provide testers with realistic data scenarios.

## 🔧 Implementation Examples

### Basic Usage in OutSystems
```
// In your server action or preparation
FirstName = GetName_FirstName("en")
LastName = GetName_LastName("en") 
Email = GetInternet_Email("en")
Phone = GetPhone_PhoneNumber("en")
```

### Creating User Profiles
```
// Generate a complete user profile
FullName = GetName_FullName("en")
Email = GetInternet_Email("en")
Username = GetInternet_UserName("en")
Phone = GetPhone_PhoneNumber("en")
Address = GetAddress_FullAddress("en")
JobTitle = GetName_JobTitle("en")
```

### E-commerce Data
```
// Generate product information
ProductName = GetCommerce_ProductName("en")
Price = GetCommerce_Price("en")
Department = GetCommerce_Department("en")
Description = GetLorem_Paragraph("en")
```

### International Data
```
// Generate localized data for different markets
FrenchName = GetName_FullName("fr")
GermanAddress = GetAddress_FullAddress("de")
SpanishPhone = GetPhone_PhoneNumber("es")
```

## ⚡ Performance Tips

1. **Locale Consistency**: Use the same locale throughout your application for consistent data style
2. **Batch Generation**: Generate multiple values in a single server action when possible
3. **Caching**: Consider caching generated data for repeated use
4. **Deterministic Data**: Use consistent parameters for reproducible results in testing

## 🛠️ Advanced Features

### Gaussian Distributions
Generate numbers following normal distribution patterns:
```
GetGaussian_Random_GaussianInt("en", mean: 100, deviation: 15)
GetGaussian_Random_GaussianDouble("en", mean: 50.0, deviation: 10.0)
```

### Date Ranges
Generate dates within specific ranges:
```
GetDate_Between("en", StartDate, EndDate)
GetUnitedKingdom_Vehicle_GbRegistrationPlate("en", StartDate, EndDate)
```

## 🐛 Troubleshooting

### Common Issues

**Invalid Locale**: If you provide an invalid locale, the extension defaults to English (`en`).

**Empty Results**: Ensure your language parameter is not empty or null.

**Performance**: For large datasets, consider generating data in batches.

## 📄 License

This extension wraps the Bogus library which is licensed under MIT. Please refer to the original Bogus license for terms and conditions.

## 🤝 Contributing

This is a wrapper extension for OutSystems ODC. For issues with the underlying data generation, please refer to the [Bogus library repository](https://github.com/bchavez/Bogus).

## 📞 Support

For OutSystems-specific issues with this extension, please refer to your OutSystems support channels.

## 🔗 Related Links

- [Bogus Library Documentation](https://github.com/bchavez/Bogus)
- [OutSystems External Libraries SDK](https://success.outsystems.com/documentation/11/extensibility_and_integration/external_libraries/)
- [OutSystems Developer Cloud Documentation](https://success.outsystems.com/documentation/outsystems_developer_cloud/)

---

**Version**: 1.0.0  
**Target Framework**: .NET 8.0  
**OutSystems Compatibility**: ODC (OutSystems Developer Cloud)  
**Bogus Version**: 35.6.3
**Developer**: Rui Pedro Gomes