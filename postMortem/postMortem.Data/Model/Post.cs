using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a post from a user with a title and message.
    /// </summary>
    public class Post : VoteableEntity
    {
        /// <summary>
        /// Entity framework requires each entity has an empty constructor for initialization purposes.
        /// </summary>
        public Post() { }
        public Post(string title, User poster)
        {
            Title = title;
            Poster = poster;
        }

        public PostStatus Status { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public virtual User Poster { get; set; }
        public virtual int? PosterID { get; set; }

        public override string EntityType => "Post";
    }
}
