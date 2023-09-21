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
        public BannedUser() { }
        public BannedUser(string banReason, DateTime untilDate, int userID)
        {
            BanReason = banReason;
            UntilDate = untilDate;
            UserID = userID;
        }

        public string BanReason { get; set; } 
        public DateTime UntilDate { get; set; }
        public virtual User User { get; set; }
        public int? UserID { get; set; }

        public override string EntityType => "BannedUser";
    }
}
