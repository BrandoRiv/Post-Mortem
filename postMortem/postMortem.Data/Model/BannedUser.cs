using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a user that has been banned from the site. Information includes
    /// things like the reason, the date the ban is lifted and the user it applies to.
    /// </summary>
    public class BannedUser : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BannedUser"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public BannedUser() 
        {
            BanReason = "";
            UntilDate = DateTime.Now;
            User = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BannedUser"/> class.
        /// </summary>
        /// <param name="banReason">Reason for the ban.</param>
        /// <param name="untilDate">Date until the ban is lifted.</param>
        /// <param name="user">The user the ban is for.</param>
        public BannedUser(string banReason, DateTime untilDate, User user)
        {
            BanReason = banReason;
            UntilDate = untilDate;
        }

        /// <summary>
        /// Reason why the user is banned.
        /// </summary>
        public string BanReason { get; set; } 

        /// <summary>
        /// Date until the ban is lifted.
        /// </summary>
        public DateTime UntilDate { get; set; }

        /// <summary>
        /// The user the ban is for.
        /// </summary>
        public virtual User? User { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "BannedUser";
    }
}
