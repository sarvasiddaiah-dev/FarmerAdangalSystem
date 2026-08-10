using System.ComponentModel.DataAnnotations;

namespace AuthenticationService.API.Configuration
{
    public sealed class JwtSettings
    {
        public const string SectionName = "JwtSettings";

        [Required]
        [MinLength(32)]
        public string SecretKey { get; set; } = string.Empty;

        [Required]
        public string Issuer { get; set; } = string.Empty;

        [Required]
        public string Audience { get; set; } = string.Empty;

        [Range(1, 1440)]
        public int ExpirationMinutes { get; set; }

        [Range(1, 365)]
        public int RefreshTokenExpirationDays { get; set; }
    }
}
