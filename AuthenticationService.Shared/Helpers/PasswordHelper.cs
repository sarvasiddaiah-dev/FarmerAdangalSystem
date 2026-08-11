using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Shared.Helpers
{
    public static class PasswordHelper
    {
        public static string ComputeSha512(string password)
        {
            ArgumentNullException.ThrowIfNull(password);
            byte[] passwordBytes=Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA512.HashData(passwordBytes);
            return Convert.ToHexString(hash);
        }
        public static bool VerifySha512(string password,string storedHash)
        {
            ArgumentNullException.ThrowIfNull(password);
            ArgumentNullException.ThrowIfNull(storedHash);
            string computeHash= ComputeSha512(password);
            return string.Equals(computeHash, storedHash,StringComparison.OrdinalIgnoreCase);
        }
    }
}
