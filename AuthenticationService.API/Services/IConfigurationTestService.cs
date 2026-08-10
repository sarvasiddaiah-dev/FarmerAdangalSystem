namespace AuthenticationService.API.Services
{
    public interface IConfigurationTestService
    {
        string GetJwtIssuer();

        string GetSmsProvider();

        string GetSmsSenderId();

        bool IsJwtConfigured();
    }
}
