using BlazorBootstrap;
using postMortem.Data.Model;
using postMortem.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postMortem.Data
{
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
        public EfRepository<postMortemContext, User> Users { get => _Users; set => _Users = value; }
        private EfRepository<postMortemContext, User> _Users;

        /// <summary>
        /// Retrieves a list of users.
        /// </summary>
        public EfRepository<postMortemContext, BannedUser> BannedUsers { get => _BannedUsers; set => _BannedUsers = value; }
        private EfRepository<postMortemContext, BannedUser> _BannedUsers;

        /// <summary>
        /// Retrieves a list of posts.
        /// </summary>
        public EfRepository<postMortemContext, Post> Posts { get => _Posts; set => _Posts = value; }
        private EfRepository<postMortemContext, Post> _Posts;

        /// <summary>
        /// Retrieves a list of comments
        /// </summary>
        public EfRepository<postMortemContext, Comment> Comments { get => _Comments; set => _Comments = value; }
        private EfRepository<postMortemContext, Comment> _Comments;

        /// <summary>
        /// Retrieves a list of comments
        /// </summary>
        public EfRepository<postMortemContext, Report> Reports { get => _Reports; set => _Reports = value; }
        private EfRepository<postMortemContext, Report> _Reports;

        /// <summary>
        /// Retrieves a list of awards
        /// </summary>
        public EfRepository<postMortemContext, Award> Awards { get => _Awards; set => _Awards = value; }
        private EfRepository<postMortemContext, Award> _Awards;

        /// <summary>
        /// Retrieves a list of votes
        /// </summary>
        public EfRepository<postMortemContext, Vote> Votes { get => _Votes; set => _Votes = value; }
        private EfRepository<postMortemContext, Vote> _Votes;

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
            _Users = new EfRepository<postMortemContext, User>(_Context);
            _Posts = new EfRepository<postMortemContext, Post>(_Context);
            _Comments = new EfRepository<postMortemContext, Comment>(_Context);
            _Reports = new EfRepository<postMortemContext, Report>(_Context);
            _Awards = new EfRepository<postMortemContext, Award>(_Context);
            _Votes = new EfRepository<postMortemContext, Vote>(_Context);
        }
    }
}
