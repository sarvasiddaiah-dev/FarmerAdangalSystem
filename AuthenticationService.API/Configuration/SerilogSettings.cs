namespace AuthenticationService.API.Configuration
{
    public sealed class SerilogSettings
    {
        public const string SectionName = "Serilog";
        public string MinimumLevel { get; set; } = "Information";
    }
}
