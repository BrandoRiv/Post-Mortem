using postMortem.Data.Model;

namespace postMortem.Web.Data
{
    public interface IAuthenticationProvider
    {
        Task<User> GetUser();
        Task<List<string>> GetRoles();
        Task<bool> HasRole(string roleName);
    }
}
