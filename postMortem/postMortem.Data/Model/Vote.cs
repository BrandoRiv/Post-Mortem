using postMortem.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Model
{
    public class Vote : Entity
    {
        public Vote() { }
        public Vote(int postID, string userID, VoteType voteType)
        {
            PostID = postID;
            UserID = userID;
            VoteType = voteType;
        }

        public virtual Post Post { get; set; }
        public int PostID { get; set; }

        public virtual User User { get; set; }
        public string UserID { get; set; }

        public VoteType VoteType { get; set; }

        public override string EntityType => "Vote";
    }
}
