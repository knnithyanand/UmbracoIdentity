using Microsoft.Owin;
using System.Linq;
using System.Web;
using Umbraco.Core.Composing;
using Umbraco.Core.Models;

namespace UmbracoIdentity
{
    internal static class MemberExtensions
    {


        /// <summary>
        /// Checks if the security stamp property exists and if so returns it, otherwise null
        /// </summary>
        /// <param name="member"></param>
        /// <param name="propertyExists">returns false if the property does not exist</param>
        /// <returns></returns>
        public static string GetSecurityStamp(this IMember member, out bool propertyExists)
        {
            propertyExists = member.Properties.Contains(UmbracoIdentityConstants.SecurityStampProperty);
            if (!propertyExists)
                return null;

            return member.Properties[UmbracoIdentityConstants.SecurityStampProperty]?.GetValue()?.ToString() ?? string.Empty;
        }

        /// <summary>
        /// Checks if the EmailConfirmed property exists and if so returns it, otherwise null
        /// </summary>
        /// <param name="member"></param>
        /// <param name="propertyExists">returns false if the property does not exist</param>
        /// <returns></returns>
        public static bool GetEmailConfirmed(this IMember member, out bool propertyExists)
        {
            propertyExists = member.Properties.Contains(UmbracoIdentityConstants.EmailConfirmedProperty);
            if (!propertyExists)
                return false;

            return member.Properties[UmbracoIdentityConstants.EmailConfirmedProperty]?.GetValue()?.ToString() == "1";
        }

        /// <summary>
        /// Checks if the PhoneNumber property exists and if so returns it, otherwise null
        /// </summary>
        /// <param name="member"></param>
        /// <param name="propertyExists">returns false if the property does not exist</param>
        /// <returns></returns>
        public static string GetPhoneNumber(this IMember member, out bool propertyExists)
        {
            propertyExists = member.Properties.Contains(UmbracoIdentityConstants.PhoneNumberProperty);
            if (!propertyExists)
                return null;

            return member.Properties[UmbracoIdentityConstants.PhoneNumberProperty]?.GetValue()?.ToString() ?? string.Empty;
        }

        /// <summary>
        /// Checks if the PhoneNumberConfirmed property exists and if so returns it, otherwise null
        /// </summary>
        /// <param name="member"></param>
        /// <param name="propertyExists">returns false if the property does not exist</param>
        /// <returns></returns>
        public static bool GetPhoneNumberConfirmed(this IMember member, out bool propertyExists)
        {
            propertyExists = member.Properties.Contains(UmbracoIdentityConstants.PhoneNumberConfirmedProperty);
            if (!propertyExists)
                return false;

            return member.Properties[UmbracoIdentityConstants.PhoneNumberConfirmedProperty]?.GetValue()?.ToString() == "1";
        }

        /// <summary>
        /// Checks if the TwoFactorEnabled property exists and if so returns it, otherwise null
        /// </summary>
        /// <param name="member"></param>
        /// <param name="propertyExists">returns false if the property does not exist</param>
        /// <returns></returns>
        public static bool GetTwoFactorEnabled(this IMember member, out bool propertyExists)
        {
            propertyExists = member.Properties.Contains(UmbracoIdentityConstants.TwoFactorEnabledProperty);
            if (!propertyExists)
                return false;

            return member.Properties[UmbracoIdentityConstants.TwoFactorEnabledProperty]?.GetValue()?.ToString() == "1";
        }
    }
}
