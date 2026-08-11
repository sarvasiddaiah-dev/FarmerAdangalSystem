using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationService.Domain.Enums;

namespace AuthenticationService.Domain.Entities
{
    public class User: BaseEntity
    {
        public string MobileNumber { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
        public bool IsMobileVerified { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public int FailedLoginAttempts { get; set; }
        public DateTime? LockedUntil { get; set; }

         
    }
}
