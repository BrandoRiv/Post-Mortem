using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents an entity that can be reported, awarded, given votes, or commented on.
    /// </summary>
    public abstract class InteractiveEntity : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveEntity"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public InteractiveEntity()
        {
            Status = PostStatus.Active;
            Comments = new List<Comment>();
            Reports = new List<Report>();
            AwardsGiven = new List<Award>();
            VotesGiven = new List<Vote>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveEntity"/> class.
        /// </summary>
        /// <param name="owner"></param>
        protected InteractiveEntity(User owner)
            : this()
        {
            this.Owner = owner;
        }

        /// <summary>
        /// The owner of this entity.
        /// </summary>
        [Required]
        public virtual User? Owner { get; set; }

        /// <summary>
        /// Current status of the entity.
        /// </summary>
        public PostStatus Status { get; set; }

        /// <summary>
        /// Is this entity locked?
        /// </summary>
        [NotMapped]
        public bool Locked { get => Status.Equals(PostStatus.Locked); }

        /// <summary>
        /// Is this entity archived?
        /// </summary>
        [NotMapped]
        public bool Archived { get => Status.Equals(PostStatus.Archive); }

        /// <summary>
        /// Is this entity deleted?
        /// </summary>
        [NotMapped]
        public bool Deleted { get => Status.Equals(PostStatus.Deleted); }

        /// <summary>
        /// Gets or sets a list of referenced comments.
        /// </summary>
        public virtual List<Comment> Comments { get; set; }

        /// <summary>
        /// Gets or sets a list of referenced reports.
        /// </summary>
        public virtual List<Report> Reports { get; set; }

        /// <summary>
        /// Gets or sets a list of referenced awards.
        /// </summary>
        public virtual List<Award> AwardsGiven { get; set; }

        /// <summary>
        /// Gets or sets a list of referenced votes.
        /// </summary>
        public virtual List<Vote> VotesGiven { get; set; }

        /// <summary>
        /// Total amount of weight this comment is given. 
        /// 0 for post
        /// 1 for comment
        /// </summary>
        [NotMapped]
        protected virtual int CommentWeight { get; } = 0;

        /// <summary>
        /// Delete all of the children so this object can be deleted.
        /// </summary>
        /// <param name="worker"></param>
        public void Delete(postMortemWorker worker)
        {
            /*
             * NOTE:
             * THIS IS NOT WHAT WE'D DO IN THE REAL WORLD.
             * This is a problem I found ): That can't be fixed easily or well
             * Our items are currently setup with the relationships of IdentityUser
             * we cant use cascade delete. So instead to make sure we can delete this monster
             * object we grab all the children and delete. We need to make sure ALL children are in memory
             * any children not in memory will cause issues down the line turning into undeletable orphans.
             */
            worker.Votes.RemoveRange(VotesGiven);
            worker.Comments.RemoveRange(Comments);
            worker.Awards.RemoveRange(AwardsGiven);
            worker.Reports.RemoveRange(Reports);
            worker.SaveChanges();
        }

        /// <summary>
        /// Gets the total amount of votes for this post given.
        /// </summary>
        /// <returns></returns>
        public int GetVotes()
        {
            int totalVotes = 0;

            // Add votes.
            VotesGiven.ForEach(v => totalVotes += v.VoteType);

            return totalVotes;
        }

        /// <summary>
        /// Gets the total amount of comments and it's children.
        /// </summary>
        public virtual int GetCommentWeight
        {
            get 
            {
                int totalComments = CommentWeight;
                Comments.ForEach(c => totalComments += c.GetCommentWeight);
                return totalComments; 
            }
        }
    }
}
