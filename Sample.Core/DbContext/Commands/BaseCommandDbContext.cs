using Microsoft.EntityFrameworkCore;

namespace Sample.Core
{
    public abstract class BaseCommandDbContext : DbContext
    {
        public BaseCommandDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}