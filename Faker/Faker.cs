using Bogus;
using System;
using System.Collections.Generic;

namespace Faker
{
    public class Faker : IFaker
    {
        // Variables

        private static readonly HashSet<string> ValidLocales = new(StringComparer.OrdinalIgnoreCase)
        {
            "af_ZA", "ar", "az", "cz", "de", "de_AT", "de_CH", "el", "en", "en_AU", "en_AU_ocker", "en_BORK",
            "en_CA", "en_GB", "en_IE", "en_IND", "en_NG", "en_US", "en_ZA", "es", "es_MX", "fa", "fi", "fr",
            "fr_CA", "fr_CH", "ge", "hr", "id_ID", "it", "ja", "ko", "lv", "nb_NO", "ne", "nl", "nl_BE",
            "pl", "pt_BR", "pt_PT", "ro", "ru", "sk", "sv", "tr", "uk", "vi", "zh_CN", "zh_TW", "zu_ZA"
        };

        private const string DefaultLocale = "en";

        // Helpers

        private static string GetMappedLocale(string language)
        {
            if (string.IsNullOrWhiteSpace(language))
                return DefaultLocale;

            var normalized = language.Trim();
            return ValidLocales.Contains(normalized) ? normalized : DefaultLocale;
        }

        private static Bogus.Faker CreateFaker(string language)
        {
            var locale = GetMappedLocale(language);
            return new Bogus.Faker(locale);
        }

        // Name related actions

        public void GetFullName(string language, out string fullname)
        {
            fullname = CreateFaker(language).Name.FullName();
        }

        public void GetFirstName(string language, out string firstname)
        {
            firstname = CreateFaker(language).Name.FirstName();
        }

        public void GetLastName(string language, out string lastname)
        {
            lastname = CreateFaker(language).Name.LastName();
        }

        public void GetJobArea(string language, out string jobarea)
        {
            jobarea = CreateFaker(language).Name.JobArea();
        }

        public void GetJobType(string language, out string jobtype)
        {
            jobtype = CreateFaker(language).Name.JobType();
        }

        public void GetJobTitle(string language, out string jobtitle)
        {
            jobtitle = CreateFaker(language).Name.JobTitle();
        }

        public void GetJobDescription(string language, out string jobdescription)
        {
            jobdescription = CreateFaker(language).Name.JobDescriptor();
        }

        // Phone realated actions

        public void GetPhoneNumber(string language, out string phonenumber)
        {
            phonenumber = CreateFaker(language).Phone.PhoneNumber();
        }

        // Internet related actions

        public void GetEmail(string language, out string email)
        {
            email = CreateFaker(language).Internet.Email();
        }

        public void GetIPv4(string language, out string ipv4)
        {
            ipv4 = CreateFaker(language).Internet.Ip();
        }

        public void GetIPv6(string language, out string ipv6)
        {
            ipv6 = CreateFaker(language).Internet.Ipv6();
        }

        public void GetMac(string language, out string mac)
        {
            mac = CreateFaker(language).Internet.Mac();
        }

        public void GetPassword(string language, out string password)
        {
            password = CreateFaker(language).Internet.Password();
        }

        public void GetPort(string language, out int port)
        {
            port = CreateFaker(language).Internet.Port();
        }

        public void GetUserName(string language, out string username)
        {
            username = CreateFaker(language).Internet.UserName();
        }

        public void GetProtocol(string language, out string protocol)
        {
            protocol = CreateFaker(language).Internet.Protocol();
        }

        public void GetUrl(string language, out string url)
        {
            url = CreateFaker(language).Internet.Url();
        }


        // Address related actions

        public void GetFullAddress(string language, out string address)
        {
            address = CreateFaker(language).Address.FullAddress();
        }

        public void GetCity(string language, out string city)
        {
            city = CreateFaker(language).Address.City();
        }

        public void GetCountry(string language, out string country)
        {
            country = CreateFaker(language).Address.Country();
        }

        public void GetState(string language, out string state)
        {
            state = CreateFaker(language).Address.State();
        }
    }
}
