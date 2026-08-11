using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Domain.Constants
{
    public static class ErrorMessages
    {
        public const string InvalidCredentials = "Invalid Mobile number or Password";
        public const string InvalidOtp = "Invalid Otp";
        public const string OtpExpired = "OTP Has Expired";
        public const string OtpAttemptsExceeded = "Maximum OTP attempts exceeded.";
        public const string UserNotFound = "User not found.";
        public const string UserAlreadyExists = "User Already Exists";
        public const string AccountLocked = "User account is Locked";
        public const string Unauthorized = "Unauthorized access.";
        public const string InvalidRefreshToken = "Invalid or Expired Refresh Token.";
        public const string PasswordMismatch = "Old Password Incorrect.";
    }
}
