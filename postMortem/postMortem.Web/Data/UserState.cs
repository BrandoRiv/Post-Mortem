using postMortem.Data.Model;

namespace postMortem.Web.Data
{
    /// <summary>
    /// Represents a way to get around the annoying Visual Studio <AuthorizedView> element. Holds the user and the roles of the user
    /// this way we can use it throughout the rest of the application without much effort.
    /// </summary>
    public class UserState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserState"/> class.
        /// </summary>
        public UserState() 
        {
            Roles = new List<string>();
        }

        /// <summary>
        /// The user who is requesting this page.
        /// </summary>
        public User Viewer { get; set; }

        /// <summary>
        /// The roles this user possesses.
        /// </summary>
        public IList<string> Roles { get; set; }

        /// <summary>
        /// Gets whether this user has a role.
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
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
