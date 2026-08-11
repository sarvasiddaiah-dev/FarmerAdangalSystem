using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Shared.Utilities
{
    public static class GuardUtility
    {
        public static void AgainstNull<T>(
        T? value,
        string parameterName)
        {
            if (value is null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        public static void AgainstNullOrEmpty(
            string? value,
            string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    $"{parameterName} cannot be null or empty.",
                    parameterName);
            }
        }
    }
}
