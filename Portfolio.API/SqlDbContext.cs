using Portfolio.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Portfolio.API
{
    public class SqlDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public IEnumerable<Student> GetCollection(Type type)
        {
            return Students;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Use the entity name instead of the Context.DbSet<T> name
                // refs https://learn.microsoft.com/en-us/ef/core/modeling/entity-types?tabs=fluent-api#table-name
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }
        }


    }
}
