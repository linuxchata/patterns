using System;
using System.Collections.Generic;

namespace Proxy
{
    public class CachedAuthenticationService : IAuthenticationService
    {
        private readonly AuthenticationService authenticationService;

        private readonly Dictionary<string, bool> cache;

        public CachedAuthenticationService()
        {
            this.authenticationService = new AuthenticationService();
            this.cache = new Dictionary<string, bool>();
        }

        public bool IsAuthenticated(string userName)
        {
            if (cache.ContainsKey(userName))
            {
                Console.WriteLine("Get cached value for IsAuthenticated user {0}.", userName);
                return this.cache[userName];
            }

            var result = this.authenticationService.IsAuthenticated(userName);

            this.cache.Add(userName, result);
            Console.WriteLine("IsAuthenticated result was added to the cache for user {0}.", userName);

            return result;
        }
    }
}
