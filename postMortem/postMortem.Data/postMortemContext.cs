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
        public postMortemContext(DbContextOptions<postMortemContext> options)
            : base(options)
        {
        }

        public DbSet<BannedUser> BannedUsers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<IdentityUser>().ToTable("user");

            modelBuilder.Entity<IdentityRole>().ToTable("role");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("userrole");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("userclaim");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("userlogin");

            base.OnModelCreating(modelBuilder);
        }
    }
}
