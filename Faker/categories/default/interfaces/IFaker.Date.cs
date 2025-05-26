using System;
using OutSystems.ExternalLibraries.SDK;

namespace Faker
{
    /// <summary>
    /// Date-related methods for the IFaker interface.
    /// This partial interface contains all date generation method definitions.
    /// </summary>
    public partial interface IFaker
    {
        #region Date Methods

        [OSAction(
            Description = "Gets a random date in the past based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Past",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetDate_Past(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random DateTimeOffset in the past based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "PastOffset",
            ReturnType = OSDataType.DateTime
        )]
        DateTimeOffset GetDate_PastOffset(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random date that will happen soon based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Soon",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetDate_Soon(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random DateTimeOffset that will happen soon based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "SoonOffset",
            ReturnType = OSDataType.DateTime
        )]
        DateTimeOffset GetDate_SoonOffset(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random date in the future based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Future",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetDate_Future(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random DateTimeOffset in the future based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "FutureOffset",
            ReturnType = OSDataType.DateTime
        )]
        DateTimeOffset GetDate_FutureOffset(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random date between two dates based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Between",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetDate_Between(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.DateTime,
                Description = "Start date"
            )]
            DateTime startDate,
            [OSParameter(
                DataType = OSDataType.DateTime,
                Description = "End date"
            )]
            DateTime endDate
        );

        [OSAction(
            Description = "Gets a random DateTimeOffset between two dates based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "BetweenOffset",
            ReturnType = OSDataType.DateTime
        )]
        DateTimeOffset GetDate_BetweenOffset(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language,
            [OSParameter(
                DataType = OSDataType.DateTime,
                Description = "Start date"
            )]
            DateTime startDate,
            [OSParameter(
                DataType = OSDataType.DateTime,
                Description = "End date"
            )]
            DateTime endDate
        );

        [OSAction(
            Description = "Gets a random recent date based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Recent",
            ReturnType = OSDataType.DateTime
        )]
        DateTime GetDate_Recent(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random recent DateTimeOffset based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "RecentOffset",
            ReturnType = OSDataType.DateTime
        )]
        DateTimeOffset GetDate_RecentOffset(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random TimeSpan based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Timespan",
            ReturnType = OSDataType.Text
        )]
        TimeSpan GetDate_Timespan(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random month name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Month",
            ReturnType = OSDataType.Text
        )]
        string GetDate_Month(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        [OSAction(
            Description = "Gets a random weekday name based on a provided language code",
            IconResourceName = "Faker.resources.Logo.png",
            ReturnName = "Weekday",
            ReturnType = OSDataType.Text
        )]
        string GetDate_Weekday(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Language code (ex: 'en', 'es', 'pt_PT')"
            )]
            string language
        );

        #endregion
    }
}