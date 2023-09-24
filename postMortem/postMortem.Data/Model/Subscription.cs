using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a user subscription the user has bought. 
    /// </summary>
    public class Subscription : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public Subscription() 
        {
            Tier = SubscriptionTier.Tier1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="user">The person receiving the award.</param>
        public Subscription(User user, SubscriptionTier tier) 
        { 
            this.User = user;
            this.Tier = tier;
        }

        /// <summary>
        /// User the subscription belongs to.
        /// </summary>
        [Required]
        public virtual User? User { get; set; }

        /// <summary>
        /// The tier of the subscription.
        /// </summary>
        public SubscriptionTier Tier { get; set; } 

        /// <summary>
        /// The date the subscription expires.
        /// </summary>
        public DateTime Until { get; set; }

        /// <summary>
        /// Has this subscription expired?
        /// </summary>
        /// <returns></returns>
        public bool HasExpired()
        {
            return DateTime.Now > Until;
        }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "Subscription";
    }
}
