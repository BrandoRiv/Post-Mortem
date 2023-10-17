using Microsoft.AspNetCore.Identity;
using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a user that has joined the community. A user can create posts, comments, gives votes and awards.
    /// </summary>
    public class User : IdentityUser, IEntity<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public User() 
        {
            Bio = "";
            Posts = new List<Post>();
            Comments = new List<Comment>();
            CreatedAt = DateTime.Now;
            Settings = new UserSettings();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="bio"></param>
        public User(string bio)
            : this()
        {
            Bio = bio;
        }

        /// <summary>
        /// Short description about the user.
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// Grab the users current subscription tier.
        /// </summary>
        public SubscriptionTier GetSubscription
        {
            get
            {
                if (ActiveSubscriptions != null)
                {
                    foreach (var subscription in ActiveSubscriptions)
                    {
                        if (!subscription.HasExpired())
                        {
                            return subscription.Tier;
                        }
                    }
                }

                return SubscriptionTier.Tier0;
            }
        }

        /// <summary>
        /// References posts.
        /// </summary>
        public virtual List<Post> Posts { get; set; }

        /// <summary>
        /// Referenced comments.
        /// </summary>
        public virtual List<Comment> Comments { get; set; }

        /// <summary>
        /// Referenced subscriptions
        /// </summary>
        public virtual List<Subscription> ActiveSubscriptions { get; set; }

        /// <summary>
        /// Referenced votes.
        /// </summary>
        public virtual List<Vote> Votes { get; set; }

        /// <summary>
        /// A group of options for the user.
        /// </summary>
        public virtual UserSettings Settings { get; set; }

        /// <summary>
        /// Date the user account was created.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }
        private DateTime _createdAt;

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public string EntityType => "User";
    }
}
