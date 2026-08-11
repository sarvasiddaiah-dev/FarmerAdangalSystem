using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationService.Domain.Constants
{
    public static class AuthenticationConstants
    {
        public const string BearerScheme = "Bearer";
        public const string AuthorizationHeader = "Authorization";
        public const string JwtTokenType = "Jwt";
        public const string RefreshTokenType = "RefreshToken";

    }
}
