using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class postMortemContext : IdentityDbContext
    {
        /// <summary>
        /// Initalizes a new instance of the <see cref="postMortemContext"/> class.
        /// </summary>
        /// <param name="options"></param>
        public postMortemContext(DbContextOptions<postMortemContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<BannedUser> BannedUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<FavoritePost> Favorites { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = "User", ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Moderator", NormalizedName = "MODERATOR", Id = "Moderator", ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = "Admin", ConcurrencyStamp = Guid.NewGuid().ToString() });

            base.OnModelCreating(modelBuilder);
        }
    }
}
