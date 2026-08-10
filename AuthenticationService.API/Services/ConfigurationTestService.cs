using AuthenticationService.API.Configuration;
using Microsoft.Extensions.Options;

namespace AuthenticationService.API.Services
{
    public class ConfigurationTestService : IConfigurationTestService
    {
        private readonly JwtSettings _jwtSettings;
        private readonly SmsSettings _smsSettings;

        public ConfigurationTestService(
            IOptions<JwtSettings> jwtOptions,
            IOptions<SmsSettings> smsOptions)
        {
            _jwtSettings = jwtOptions.Value;
            _smsSettings = smsOptions.Value;
        }

        public string GetJwtIssuer()
        {
            return _jwtSettings.Issuer;
        }

        public string GetSmsProvider()
        {
            return _smsSettings.Provider;
        }

        public string GetSmsSenderId()
        {
            return _smsSettings.SenderId;
        }
        public bool IsJwtConfigured()
        {
            return !string.IsNullOrWhiteSpace(_jwtSettings.SecretKey);
        }
    }
}
