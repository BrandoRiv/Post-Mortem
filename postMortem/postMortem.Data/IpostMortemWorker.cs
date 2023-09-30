using postMortem.Data.Model;
using postMortem.Data.Repository;
using postMortem.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data
{
    /// <summary>
    /// Represents the concrete instance of repositiores our worker should use.
    /// </summary>
    internal interface IpostMortemWorker : IWorker<postMortemContext>
    {
        IUserRepository Users { get; set; }
        IBannedUserRepository BannedUsers { get; set; }
        IPostRepository Posts { get; set; }
        ICommentRepository Comments { get; set; }
        ITagRepository Tags { get; set; }
        IReportRepository Reports { get; set; }
        IAwardRepository Awards { get; set; }
        ISubscriptionRepository Subscriptions { get; set; }
        IVoteRepository Votes { get; set; }
    }
}
