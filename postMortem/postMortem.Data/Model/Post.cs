using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class Post : Entity
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

        public string Title { get; set; }

        /// <summary>
        /// References objects must be set as virtual.
        /// </summary>
        public virtual User Poster { get; set; }

        public override string EntityType => "Post";
    }
}
