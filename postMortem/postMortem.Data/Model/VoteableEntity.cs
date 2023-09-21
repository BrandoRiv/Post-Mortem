using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents an entity that can be reported, awarded, given votes, or commented on.
    /// </summary>
    public abstract class VoteableEntity : Entity
    {
        protected VoteableEntity()
        {
            Comments = new List<Comment>();
            Reports = new List<Report>();
            AwardsGiven = new List<Award>();
            VotesGiven = new List<Vote>();
        }

        public bool Archived { get; set; }
        public bool Deleted { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Report> Reports { get; set; }
        public virtual List<Award> AwardsGiven { get; set; }
        public virtual List<Vote> VotesGiven { get; set; }
    }
}
