using System;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var authenticationService = new CachedAuthenticationService();
            authenticationService.IsAuthenticated("John Oliver");
            authenticationService.IsAuthenticated("Kazil Prokop");
            authenticationService.IsAuthenticated("Kazil Prokop");
            authenticationService.IsAuthenticated("Kazil Prokop");
            authenticationService.IsAuthenticated("Kazil Prokop");
            authenticationService.IsAuthenticated("Kazil Prokop");
            authenticationService.IsAuthenticated("John Oliver");
            authenticationService.IsAuthenticated("Fernando Alonso");

            Console.ReadKey();
        }
    }
}
