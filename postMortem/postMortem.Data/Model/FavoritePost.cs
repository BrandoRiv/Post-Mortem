using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    /// <summary>
    /// Represents a favorite of the user of what post they like.
    /// </summary>
    public class FavoritePost : Entity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FavoritePost"/> class.
        /// </summary>
        public FavoritePost()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoritePost"/> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="post"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public FavoritePost(User user, Post post)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            Post = post ?? throw new ArgumentNullException(nameof(post));
        }

        /// <summary>
        /// The user this favorite belongs to.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// The post the user favorited.
        /// </summary>
        public virtual Post Post { get; set; }

        /// <summary>
        /// Internally determine what type of entity this is by it's type.
        /// </summary>
        public override string EntityType => "Favorite Post";
    }
}
