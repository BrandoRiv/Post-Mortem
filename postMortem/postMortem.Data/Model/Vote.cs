﻿using postMortem.Data.Common;
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
        public Vote(string userID, VoteType voteType)
        {
            UserID = userID;
            VoteType = voteType;
        }

        public virtual VoteableEntity Entity { get; set; }
        public int? EntityID { get; set; }

        public virtual User User { get; set; }
        public string? UserID { get; set; }

        public VoteType VoteType { get; set; }

        public override string EntityType => "Vote";
    }
}
