namespace Proxy
{
    public interface IAuthenticationService
    {
        bool IsAuthenticated(string userName);
    }
}
