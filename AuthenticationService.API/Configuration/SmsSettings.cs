namespace AuthenticationService.API.Configuration
{
    public sealed class SmsSettings
    {
        public const string SectionName = "SmsSettings";
        public string Provider { get; set; } = string.Empty;
        public string ApiUrl { get; set; } = string.Empty;
        public string AuthKey { get; set; } = string.Empty;
        public string SenderId { get; set; } = string.Empty;
        public string Route { get; set; } = string.Empty;
        public string TemplateId { get; set; } = string.Empty;
    }
}
