using System.ComponentModel.DataAnnotations;

namespace AuthenticationService.API.Configuration
{
    public sealed class ApplicationSettings
    {
        public const string SectionName = "ApplicationSettings";

        [Required]
        public string ApplicationName { get; set; } = string.Empty;

        [Required]
        public string Environment { get; set; } = string.Empty;
    }
}
