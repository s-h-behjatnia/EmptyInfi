using Microsoft.EntityFrameworkCore;
using Sample.Core;

namespace Sample.EntityFramework.Queries
{
    public interface ISampleQueryRepository { }
    public class SampleQueryRepository<TEntity, Tkey> : ISampleQueryRepository, IBaseQueryRepository<TEntity, Tkey> where TEntity : Entity<Tkey> where Tkey : notnull
    {
        SampleQueryDbContext _sampleQueryDbContext => Extentions.GetService<SampleQueryDbContext>();
        public TEntity Get(Tkey id)
        {
            return _sampleQueryDbContext.Set<TEntity>().Single(it => it.Id.Equals(id));
        }
        public List<TEntity> ExecuteQuery(string query)
        {
            var x = _sampleQueryDbContext.Set<TEntity>().FromSqlRaw($"{query}").ToList();
            return x;
        }
    }
}