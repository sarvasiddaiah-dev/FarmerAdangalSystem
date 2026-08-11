using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Shared.Utilities
{
    public static class MaskingUtility
    {
        public static string MaskMobileNumber(string? mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
            {
                return string.Empty;
            }

            if (mobileNumber.Length != 10)
            {
                return "**********";
            }

            return $"******{mobileNumber[^4..]}";
        }
        public static string MaskEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return string.Empty;
            }

            int atIndex = email.IndexOf('@');

            if (atIndex <= 0)
            {
                return "********";
            }

            string firstCharacter = email[..1];
            string domain = email[atIndex..];

            return $"{firstCharacter}****{domain}";
        }
    }
}
