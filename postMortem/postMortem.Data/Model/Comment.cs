using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a comment on a post, or a child comment on another post. Includes information
    /// like the parent post and the parent comment if any.
    /// </summary>
    public class Comment : VoteableEntity
    {
        public Comment() { }
        public Comment(string message, int entityID)
        {
            Message = message;
        }

        public string Message { get; set; }
        public virtual VoteableEntity Entity { get; set; }
        public virtual User User { get; set; }

        public override string EntityType => "Comment";
    }
}
