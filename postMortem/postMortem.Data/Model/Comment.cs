using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a comment on a post, or a child comment on another post. Includes information
    /// like the parent post and the parent comment if any.
    /// </summary>
    public class Comment : InteractiveEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Comment"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public Comment() 
        {
            Message = "";
            Parent = null;
        }
        
        /// <summary>
        /// Initialize a new instance of the <see cref="Comment"/> class. 
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="parent">The parent this comment belongs to.</param>
        public Comment(string message, User poster, InteractiveEntity parent = null)
            : base(poster)
        {
            Message = message;
            Parent = parent;
        }

        /// <summary>
        /// The parent of the entity. Comments require a parent.
        /// </summary>
        [Required]
        public virtual InteractiveEntity? Parent { get; set; }

        /// <summary>
        /// Message the user would like to display.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Returns the total weight of this item.
        /// </summary>
        protected override int CommentWeight { get => 1; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "Comment";
    }
}
