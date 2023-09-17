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
        public TContext Context { get; }
        public void SaveChanges();
    }
}
