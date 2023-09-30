using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Common
{
    /// <summary>
    /// Represents a subscription tier for each user. Tier 0 being the default tier with 1 and 2 being a premium.
    /// premium users can give out different types of awards, and avoid ads.
    /// </summary>
    public enum SubscriptionTier
    {
        /// <summary>
        /// Default user tier.
        /// </summary>
        Tier0,

        /// <summary>
        /// Premium tier 1
        /// </summary>
        Tier1,

        /// <summary>
        /// Premium tier 2.
        /// </summary>
        Tier2
    }
}
