using Microsoft.EntityFrameworkCore;
using Sample.Core;

namespace Sample.EntityFramework.Queries
{
    public class SampleQueryDbContext : BaseQueryDbContext
    {
        public SampleQueryDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}