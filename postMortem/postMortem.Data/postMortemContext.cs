using Microsoft.EntityFrameworkCore;
using postMortem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data
{
    /// <summary>
    /// Represents our database caller for the <see cref="postMortem"/> database.
    /// Add a DbSet<T> for every entity we should see in the database.
    /// </summary>
    public class postMortemContext : DbContext
    {
        public postMortemContext(DbContextOptions<postMortemContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
