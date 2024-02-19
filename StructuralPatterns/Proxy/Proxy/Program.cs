using System;

namespace Proxy
{
    /// <summary>
    /// Provide a surrogate or placeholder for another object to control access to it.
    /// Variants of the Proxy pattern
    /// A remote proxy provides a connection to the object being replaced, which is in a different address space.
    /// A virtual proxy performs the creation of the replaced object only when it is really needed.
    /// A protection proxy checks if the client has the necessary access rights to complete the request.
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
