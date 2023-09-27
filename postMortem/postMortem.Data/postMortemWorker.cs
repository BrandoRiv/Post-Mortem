using BlazorBootstrap;
using postMortem.Data.Model;
using postMortem.Data.Repository;
using postMortem.Data.Repository.Instance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postMortem.Data
{
    /// <summary>
    /// Represents our worker class for the <see cref="postMortemContext"/>. The worker class helps bring concrete classes together
    /// so we can use our referenced repositories instead of using the default DbSet methods.
    /// </summary>
    public class postMortemWorker : IpostMortemWorker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="postMortemWorker"/> class.
        /// </summary>
        /// <param name="context">Database handler instance.</param>
        /// <exception cref="ArgumentNullException">Thrown if context is null.</exception>
        public postMortemWorker(postMortemContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.Context = context;

            InitializeRepository();
        }

        /// <summary>
        /// Gets the current instance of <see cref="postMortemContext"/>.
        /// </summary>
        public postMortemContext Context
        {
            get { return _Context; }
            private set { _Context = value; }
        }
        private postMortemContext _Context;

        /// <summary>
        /// Retrieves a list of users.
        /// </summary>
        public UserRepository Users { get => _Users; set => _Users = value; }
        private UserRepository _Users;

        /// <summary>
        /// Retrieves a list of users.
        /// </summary>
        public BannedUserRepository BannedUsers { get => _BannedUsers; set => _BannedUsers = value; }
        private BannedUserRepository _BannedUsers;

        /// <summary>
        /// Retrieves a list of posts.
        /// </summary>
        public PostRepository Posts { get => _Posts; set => _Posts = value; }
        private PostRepository _Posts;

        /// <summary>
        /// Retrieves a list of comments
        /// </summary>
        public CommentRepository Comments { get => _Comments; set => _Comments = value; }
        private CommentRepository _Comments;

        /// <summary>
        /// Retrieves a list of tags
        /// </summary>
        public CommentRepository Tags { get => _Tags; set => _Tags = value; }
        private CommentRepository _Tags;

        /// <summary>
        /// Retrieves a list of comments
        /// </summary>
        public ReportRepository Reports { get => _Reports; set => _Reports = value; }
        private ReportRepository _Reports;

        /// <summary>
        /// Retrieves a list of awards
        /// </summary>
        public AwardRepository Awards { get => _Awards; set => _Awards = value; }
        private AwardRepository _Awards;

        /// <summary>
        /// Retrieves a list of awards
        /// </summary>
        public SubscriptionRepository Subscriptions { get => _Subscriptions; set => _Subscriptions = value; }
        private SubscriptionRepository _Subscriptions;

        /// <summary>
        /// Retrieves a list of votes
        /// </summary>
        public VoteRepository Votes { get => _Votes; set => _Votes = value; }
        private VoteRepository _Votes;

        /// <summary>
        /// Dispose of the current object.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Dispose()
        {
            _Context.Dispose();
        }

        /// <summary>
        /// Save the changes for the current context.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        /// <summary>
        /// Initialize default instances of each repository.
        /// </summary>
        private void InitializeRepository()
        {
            _Users = new UserRepository(_Context);
            _Posts = new PostRepository(_Context);
            _Comments = new CommentRepository(_Context);
            _Tags = new CommentRepository(_Context);
            _Reports = new ReportRepository(_Context);
            _Awards = new AwardRepository(_Context);
            _Subscriptions = new SubscriptionRepository(_Context);
            _Votes = new VoteRepository(_Context);
        }
    }
}
