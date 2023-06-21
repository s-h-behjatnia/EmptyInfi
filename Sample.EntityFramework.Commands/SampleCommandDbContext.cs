using Microsoft.EntityFrameworkCore;
using Sample.Core;

namespace Sample.EntityFramework.Commands
{
    public class SampleCommandDbContext : BaseCommandDbContext
    {
        public SampleCommandDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}