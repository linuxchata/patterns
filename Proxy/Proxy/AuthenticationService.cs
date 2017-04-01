using System;

namespace Proxy
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool IsAuthenticated(string userName)
        {
            Console.WriteLine("User {0} was authenticated.", userName);
            return true;
        }
    }
}
