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
    public class User : IdentityUser, IEntity
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
        /// DO. NOT. USE. Use <see cref="IdentityUser"/> Id.
        /// </summary>
        [NotMapped]
        public int ID
        {
            get { return base.Id.GetHashCode(); }
            set { throw new NotSupportedException(); }
        }

        /// <summary>
        /// Short description about the user.
        /// </summary>
        public string Bio { get; set; }

        /// <summary>
        /// References posts.
        /// </summary>
        public virtual List<Post> Posts { get; set; }

        /// <summary>
        /// Referenced comments.
        /// </summary>
        public virtual List<Comment> Comments { get; set; }

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
