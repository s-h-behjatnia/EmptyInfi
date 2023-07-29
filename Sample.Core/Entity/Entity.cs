namespace Sample.Core
{
    public class Entity<Tkey> : IEntity<Tkey> where Tkey : notnull
    {
        public Tkey Id { get; set; }
    }

    public class Entity : Entity<Guid> { }
}