namespace Sample.Core
{
    public class Entity<Tkey> : IEntity where Tkey : struct
    {
        public Tkey Id { get; protected set; }
    }
    
    public class Entity : Entity<Guid> { }
}