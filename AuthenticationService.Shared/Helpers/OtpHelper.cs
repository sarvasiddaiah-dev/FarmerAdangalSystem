using AuthenticationService.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Shared.Helpers
{
    public static class OtpHelper
    {
        public static string Generateotp()
        {
            return RandomNumberGenerator.GetInt32(100000,1000000).ToString();
        }
        public static bool IsvalidOtpFormat(string? otp)
        {
            return !string.IsNullOrWhiteSpace(otp) && otp.Length == OtpConstants.OptLength && otp.All(char.IsDigit);
        }
    }
}
