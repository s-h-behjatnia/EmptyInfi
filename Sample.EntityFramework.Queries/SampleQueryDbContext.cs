using Microsoft.EntityFrameworkCore;
using Sample.Core;
using Sample.Domain;
using Sample.Model;

namespace Sample.EntityFramework.Queries
{
    public class SampleQueryDbContext : BaseQueryDbContext
    {
        public DbSet<SomeModel> SomeModels { get; set; }
        public SampleQueryDbContext(DbContextOptions<SampleQueryDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SomeModel>().HasNoKey();
        }
    }
}