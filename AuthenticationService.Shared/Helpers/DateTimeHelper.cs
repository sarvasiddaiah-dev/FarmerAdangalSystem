using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Shared.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime Utcnow()
        {
            return DateTime.UtcNow;
        }
        public static DateTime AddMinutes(int Minutes)
        {
            return DateTime.UtcNow.AddMinutes(Minutes);
        }
        public static DateTime AddDays(int days)
        {
            return DateTime.UtcNow.AddDays(days);
        }
        public static bool IsExpired(DateTime expiryTime)
        {
            return DateTime.UtcNow>= expiryTime;
        }
    }
}
