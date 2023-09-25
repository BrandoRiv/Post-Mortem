using postMortem.Data.Model;
using postMortem.Data.Repository;
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
        EfRepository<postMortemContext, User> Users { get; set; }
        EfRepository<postMortemContext, BannedUser> BannedUsers { get; set; }
        EfRepository<postMortemContext, Post> Posts { get; set; }
        EfRepository<postMortemContext, Comment> Comments { get; set; }
        EfRepository<postMortemContext, Report> Reports { get; set; }
        EfRepository<postMortemContext, Award> Awards { get; set; }
        EfRepository<postMortemContext, Subscription> Subscriptions { get; set; }
        EfRepository<postMortemContext, Vote> Votes { get; set; }
    }
}
