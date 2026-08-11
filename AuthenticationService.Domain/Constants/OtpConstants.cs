using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Domain.Constants
{
    public static class OtpConstants
    {
        public const int OptLength = 6;
        public const int OtpExpiryMinutes = 5;
        public const int MaxOtpAttempts = 3;
    }
}
