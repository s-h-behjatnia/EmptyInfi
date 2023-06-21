using Microsoft.EntityFrameworkCore;

namespace Sample.Core
{
    public abstract class BaseQueryDbContext : DbContext
    {
        public BaseQueryDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public override int SaveChanges()
        {
            throw new NotImplementedException();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            throw new NotImplementedException();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}