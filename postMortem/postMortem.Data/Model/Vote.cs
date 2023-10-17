using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a vote that can be added to a post or comment to support, or reject.
    /// </summary>
    public class Vote : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vote"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public Vote() 
        {
            Recipient = null;
        }

        /// <summary>
        /// Initalizes a new instance of the <see cref="Vote"/> class.
        /// </summary>
        /// <param name="recipient">Entity receiving the vote.</param>
        /// <param name="voteType">Type of vote, good or bad. Use 0 for bad, or 1 for good.</param>
        public Vote(User user, InteractiveEntity recipient, int voteType)
        {
            Giver = user;
            Recipient = recipient;
            VoteType = voteType;
        }
        
        /// <summary>
        /// User who gave the vote.
        /// </summary>
        public virtual User Giver { get; set; } 

        /// <summary>
        /// Entity the vote is applied to.
        /// </summary>
        public virtual InteractiveEntity? Recipient { get; set; }

        /// <summary>
        /// What type of vote is being applied. Use -1 for bad, or 1 for good.
        /// </summary>
        public int VoteType { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "Vote";
    }
}
