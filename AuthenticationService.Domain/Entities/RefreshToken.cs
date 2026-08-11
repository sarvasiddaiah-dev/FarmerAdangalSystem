using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Domain.Entities
{
    public class RefreshToken
    {
        public long UserId { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime ExpiresAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public bool IsRevoked { get; set; }
        public User? User { get; set; }
    }
}
