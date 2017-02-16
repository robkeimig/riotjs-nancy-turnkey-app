using Microsoft.EntityFrameworkCore;

namespace NancyApplication.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options) { }
 
        public DbSet<User> Users { get; set; }
 
        public DbSet<Post> Posts { get; set; }
    }
}
