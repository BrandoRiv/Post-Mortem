using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Common
{
    /// <summary>
    /// Details the status of a post or comment. This will help determine if new comments or awards can be given.
    /// </summary>
    public enum PostStatus
    {
        /// <summary>
        /// The entity is new and able to receive votes, awards, and reports.
        /// </summary>
        Active,

        /// <summary>
        /// The entity is inactive. It cannot receive votes, awards, or reports.
        /// </summary>
        Archive,

        /// <summary>
        /// The entity is locked. It cannot receive votes, awards, or reports.
        /// </summary>
        Locked,

        /// <summary>
        /// The entity is deleted. It should not be displayed to the users.
        /// </summary>
        Deleted
    }
}
