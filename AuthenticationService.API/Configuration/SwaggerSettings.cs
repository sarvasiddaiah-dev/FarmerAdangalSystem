namespace AuthenticationService.API.Configuration
{
    public sealed class SwaggerSettings
    {
        public const string SectionName = "Swagger";
        public string Title { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
    }
}
