using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a group of settings for the user.
    /// </summary>
    public class UserSettings : Entity
    {
        /// <summary>
        /// Initializes a new instance of the user settings.
        /// </summary>
        public UserSettings()
        {
            UseDarkMode = false;
            ShowNSFWContent = false;
            PrivateAccount = false;
        }

        /// <summary>
        /// Use the dark theme for the user.
        /// </summary>
        public bool UseDarkMode { get; set; }

        /// <summary>
        /// Show NSFW posts when browsing.
        /// </summary>
        public bool ShowNSFWContent { get; set; }

        /// <summary>
        /// Don't show other users the account posts.
        /// </summary>
        public bool PrivateAccount { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "UserSettings";
    }
}
