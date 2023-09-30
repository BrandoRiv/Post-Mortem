using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Common
{
    /// <summary>
    /// Details the current status of a report.
    /// </summary>
    public enum ReportStatus
    {
        /// <summary>
        /// Voting is still occuring.
        /// </summary>
        Undecided,

        /// <summary>
        /// The time for a report has ended. The report has been archived.
        /// </summary>
        Archived,

        /// <summary>
        /// The entity has been found guilty.
        /// </summary>
        Guilty,

        /// <summary>
        /// The entity has been found innocent.
        /// </summary>
        Innocent
    }
}
