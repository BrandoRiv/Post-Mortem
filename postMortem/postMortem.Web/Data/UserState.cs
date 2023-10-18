using postMortem.Data.Model;

namespace postMortem.Web.Data
{
    public class UserState
    {
        public UserState() 
        {
            Roles = new List<string>();
        }

        public User Viewer { get; set; }
        public IList<string> Roles { get; set; }

        public bool HasRole(params string[] roles)
        {
            foreach (string role in Roles)
            {
                if (roles.Contains(role))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
