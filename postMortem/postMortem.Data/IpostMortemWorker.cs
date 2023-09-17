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
        EfRepository<postMortemContext, Post> Posts { get; set; }
    }
}
