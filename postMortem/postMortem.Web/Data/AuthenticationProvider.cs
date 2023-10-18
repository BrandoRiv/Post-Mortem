using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using NuGet.DependencyResolver;
using postMortem.Data;
using postMortem.Data.Model;

namespace postMortem.Web.Data
{
    public class AuthenticationProvider : IAuthenticationProvider
    {
        private AuthenticationStateProvider _provider;
        private UserManager<User> _userMan;
        private postMortemWorker _worker;

        public AuthenticationProvider(AuthenticationStateProvider provider, UserManager<User> userMan, postMortemWorker worker) 
        {
            _provider = provider;
            _userMan = userMan;
            _worker = worker;
        }

        public async Task<User> GetUser()
        {
            // Grab the user authentication then grab the user account.
            var authState = await _provider.GetAuthenticationStateAsync();
            return _worker.Users.FirstOrDefault(r => r.UserName == authState.User.Identity.Name);
        }

        public async Task<List<string>> GetRoles()
        {
            User user = await GetUser();
            IList<string> result = await _userMan.GetRolesAsync(user);

            return result.ToList();
        }

        public async Task<bool> HasRole(string roleName)
        {
            List<string> roles = await GetRoles();
            return roles.Contains(roleName);
        }
    }
}
