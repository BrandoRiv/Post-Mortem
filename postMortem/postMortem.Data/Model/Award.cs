using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class Award : Entity
    {
        public Award() { }
        public Award(string name, string details, int postID, int userID, int fromID)
        {
            Name = name;
            Details = details;
            PostID = postID;
            UserID = userID;
            FromID = fromID;
        }

        public string Name { get; set; }
        public string Details { get; set; }

        public virtual Post Post { get; set; }
        public int PostID { get; set; }

        public virtual User User { get; set; }
        public int UserID { get; set; }

        public virtual User From { get; set; }
        public int FromID { get; set; }

        public override string EntityType => "Award";
    }
}
