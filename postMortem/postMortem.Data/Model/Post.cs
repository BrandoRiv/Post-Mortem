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
    public class Post : InteractiveEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Post"/> class. This constructor is required for entity framework to include it.
        /// </summary>
        public Post() 
        {
            Title = "";
            Message = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Post"/> class. 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public Post(string title, string message, User poster)
            : base(poster)
        {
            Title = title;
            Message = message;
        }

        /// <summary>
        /// Title of the post.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Message included with the post.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "Post";
    }
}
