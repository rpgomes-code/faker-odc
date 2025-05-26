using System.Net;

namespace Faker
{
    /// <summary>
    /// Internet-related methods for the Faker class.
    /// This partial class contains all internet generation functionality.
    /// </summary>
    public partial class Faker
    {
        #region Internet Methods

        /// <summary>
        /// Generates a random avatar from twitter (x) based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random avatar from twitter (x).</returns>
        public string GetInternet_Avatar(string language)
        {
            return CreateFaker(language).Internet.Avatar();
        }

        /// <summary>
        /// Generates a random email address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random email address.</returns>
        public string GetInternet_Email(string language)
        {
            return CreateFaker(language).Internet.Email();
        }

        /// <summary>
        /// Generates a random example email address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random example email address.</returns>
        public string GetInternet_ExampleEmail(string language)
        {
            return CreateFaker(language).Internet.ExampleEmail();
        }

        /// <summary>
        /// Generates a random username based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random username.</returns>
        public string GetInternet_UserName(string language)
        {
            return CreateFaker(language).Internet.UserName();
        }

        /// <summary>
        /// Generates a random username unicode based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random username unicode.</returns>
        public string GetInternet_UserNameUnicode(string language)
        {
            return CreateFaker(language).Internet.UserNameUnicode();
        }

        /// <summary>
        /// Generates a random domain name based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random domain name.</returns>
        public string GetInternet_DomainName(string language)
        {
            return CreateFaker(language).Internet.DomainName();
        }

        /// <summary>
        /// Generates a random domain word based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random domain word.</returns>
        public string GetInternet_DomainWord(string language)
        {
            return CreateFaker(language).Internet.DomainWord();
        }

        /// <summary>
        /// Generates a random domain suffix based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random domain suffix.</returns>
        public string GetInternet_DomainSuffix(string language)
        {
            return CreateFaker(language).Internet.DomainSuffix();
        }

        /// <summary>
        /// Generates a random IPv4 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv4 address.</returns>
        public string GetInternet_Ip(string language)
        {
            return CreateFaker(language).Internet.Ip();
        }

        /// <summary>
        /// Generates a random port number based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random port number.</returns>
        public int GetInternet_Port(string language)
        {
            return CreateFaker(language).Internet.Port();
        }

        /// <summary>
        /// Generates a random IPv4 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv4 address.</returns>
        public IPAddress GetInternet_IpAddress(string language)
        {
            return CreateFaker(language).Internet.IpAddress();
        }

        /// <summary>
        /// Generates a random IPv4 endpoint based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv4 endpoint.</returns>
        public IPEndPoint GetInternet_IpEndPoint(string language)
        {
            return CreateFaker(language).Internet.IpEndPoint();
        }

        /// <summary>
        /// Generates a random IPv6 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv6 address.</returns>
        public string GetInternet_Ipv6(string language)
        {
            return CreateFaker(language).Internet.Ipv6();
        }

        /// <summary>
        /// Generates a random IPv6 address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv6 address.</returns>
        public IPAddress GetInternet_Ipv6Address(string language)
        {
            return CreateFaker(language).Internet.Ipv6Address();
        }

        /// <summary>
        /// Generates a random IPv6 endpoint based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random IPv6 endpoint.</returns>
        public IPEndPoint GetInternet_Ipv6EndPoint(string language)
        {
            return CreateFaker(language).Internet.Ipv6EndPoint();
        }

        /// <summary>
        /// Generates a random user agent based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random user agent.</returns>
        public string GetInternet_UserAgent(string language)
        {
            return CreateFaker(language).Internet.UserAgent();
        }

        /// <summary>
        /// Generates a random MAC address based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random MAC address.</returns>
        public string GetInternet_Mac(string language)
        {
            return CreateFaker(language).Internet.Mac();
        }

        /// <summary>
        /// Generates a random password based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random password.</returns>
        public string GetInternet_Password(string language)
        {
            return CreateFaker(language).Internet.Password();
        }

        /// <summary>
        /// Generates a random internet color based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random internet color.</returns>
        public string GetInternet_Color(string language)
        {
            return CreateFaker(language).Internet.Color();
        }

        /// <summary>
        /// Generates a random protocol based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random protocol.</returns>
        public string GetInternet_Protocol(string language)
        {
            return CreateFaker(language).Internet.Protocol();
        }

        /// <summary>
        /// Generates a random URL based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random URL.</returns>
        public string GetInternet_Url(string language)
        {
            return CreateFaker(language).Internet.Url();
        }

        /// <summary>
        /// Generates a random url with path based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random url with path.</returns>
        public string GetInternet_UrlWithPath(string language)
        {
            return CreateFaker(language).Internet.UrlWithPath();
        }

        /// <summary>
        /// Generates a random url rooted path based on the provided language code.
        /// </summary>
        /// <param name="language">The language code for localization.</param>
        /// <returns>A random url rooted path.</returns>
        public string GetInternet_UrlRootedPath(string language)
        {
            return CreateFaker(language).Internet.UrlRootedPath();
        }

        #endregion
    }
}