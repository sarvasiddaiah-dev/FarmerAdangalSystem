using AuthenticationService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Domain.Entities
{
    public class OtpVerification
    {
        public string MobileNumber { get; set; } = string.Empty;
        public string OtpHash { get; set; } = string.Empty;
        public OtpPurpose Purpose { get; set; }
        public DateTime ExpiresAt { get; set; }
        public int Attempts { get; set; }   
        public bool IsVerified { get; set; }    
        public DateTime? VerifiedAt { get; set; }

    }
}
