using Microsoft.EntityFrameworkCore;
using NancyApplication.Model;

namespace NancyApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> UserEntries { get; set; }

        public DbSet<Post> PostEntries { get; set; }

        public DbSet<Comment> CommentEntries { get; set; }

        public DbSet<Board> BoardEntries { get; set; }
    }
}
