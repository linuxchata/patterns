namespace Proxy
{
    /// <summary>
    /// The 'Subject' interface
    /// </summary>
    public interface IAuthenticationService
    {
        bool IsAuthenticated(string userName);
    }
}
