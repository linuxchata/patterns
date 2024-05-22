using System;

namespace Proxy
{
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    public sealed class AuthenticationService : IAuthenticationService
    {
        public bool IsAuthenticated(string userName)
        {
            Console.WriteLine("User {0} was authenticated.", userName);
            return true;
        }
    }
}
