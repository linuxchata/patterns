using System;
using System.Collections.Generic;

namespace Proxy
{
    /// <summary>
    /// The 'Proxy' class
    /// </summary>
    public class CachedAuthenticationService : IAuthenticationService
    {
        private readonly AuthenticationService _authenticationService;

        private readonly Dictionary<string, bool> _cache;

        public CachedAuthenticationService()
        {
            _authenticationService = new AuthenticationService();
            _cache = new Dictionary<string, bool>();
        }

        public bool IsAuthenticated(string userName)
        {
            if (_cache.ContainsKey(userName))
            {
                Console.WriteLine("Get cached value for IsAuthenticated for the user {0}.", userName);
                return _cache[userName];
            }

            var result = _authenticationService.IsAuthenticated(userName);

            _cache.Add(userName, result);
            Console.WriteLine("IsAuthenticated result was added to the cache for the user {0}.", userName);

            return result;
        }
    }
}
