using Microsoft.AspNetCore.Components.Authorization;
using postMortem.Data;
using postMortem.Data.Model;

namespace postMortem.Web.Data
{
    public class AuthenticationProvider : IAuthenticationProvider
    {
        private AuthenticationStateProvider _provider;
        private postMortemWorker _worker;

        public AuthenticationProvider(AuthenticationStateProvider provider, postMortemWorker worker) 
        {
            _provider = provider;
            _worker = worker;
        }

        public async Task<User> GetUser()
        {
            // Grab the user authentication then grab the user account.
            var authState = await _provider.GetAuthenticationStateAsync();
            return _worker.Users.FirstOrDefault(r => r.UserName == authState.User.Identity.Name);
        }
    }
}
