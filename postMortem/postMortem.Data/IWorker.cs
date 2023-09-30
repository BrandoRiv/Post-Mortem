using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data
{
    /// <summary>
    /// Represents a worker class for a <see cref="DbContext"/> class
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    internal interface IWorker<TContext> : IDisposable
        where TContext : DbContext
    {
        /// <summary>
        /// Represents the context to the database.
        /// </summary>
        public TContext Context { get; }

        /// <summary>
        /// Save the current context changes to the database.
        /// </summary>
        public void SaveChanges();
    }
}
