using System;

namespace Proxy
{
    /// <summary>
    /// Provide a surrogate or placeholder for another object to control access to it.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var authenticationService = new CachedAuthenticationService();
            authenticationService.IsAuthenticated("John Oliver");
            authenticationService.IsAuthenticated("Samantha Williams");
            authenticationService.IsAuthenticated("Samantha Williams");
            authenticationService.IsAuthenticated("Samantha Williams");
            authenticationService.IsAuthenticated("Samantha Williams");
            authenticationService.IsAuthenticated("Samantha Williams");
            authenticationService.IsAuthenticated("John Oliver");
            authenticationService.IsAuthenticated("Adam Smith");

            Console.ReadKey();
        }
    }
}
