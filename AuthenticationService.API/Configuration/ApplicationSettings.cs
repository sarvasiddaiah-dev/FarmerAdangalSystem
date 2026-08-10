namespace AuthenticationService.API.Configuration
{
    public sealed class ApplicationSettings
    {
        public const string SectionName = "Application";
        public string Name { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
    }
}
