using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AuthenticationService.Shared.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValidMobileNumber(string?  mobileNumber)
        {
            if(string.IsNullOrWhiteSpace(mobileNumber))
            {
                return false;
            }
            return Regex.IsMatch(
                mobileNumber, 
                @"^[6-9]\d{9}$");
        }
        public static bool IsValidEmail(string? email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
