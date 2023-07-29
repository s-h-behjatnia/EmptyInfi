
namespace Sample.Core
{
    public interface IBaseQueryRepository<TEntity, Tkey> where TEntity : Entity<Tkey> where Tkey:notnull
    {
        TEntity Get(Tkey id);
    }
    public abstract class BaseQueryRepository<TEntity, Tkey> : IBaseQueryRepository<TEntity, Tkey> where TEntity : Entity<Tkey> where Tkey:notnull
    {
        public abstract TEntity Get(Tkey id);
    }
}