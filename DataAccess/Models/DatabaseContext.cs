using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Recomendation> recomendation { get; set; }
        public DbSet<Comment> comment { get; set; }
        public DbSet<Rating> rating { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}