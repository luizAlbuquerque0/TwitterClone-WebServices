using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Core.Entites;

namespace TwitterClone.Infrastructure.Persistence
{
    internal class TwitterCloneDbContext : DbContext
    {
        public TwitterCloneDbContext(DbContextOptions<TwitterCloneDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get;  set; }
        public DbSet<Post> Posts { get;  set; }
        public DbSet<PostComment> PostComments { get;  set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
