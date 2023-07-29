namespace Sample.Core
{
    public interface IEntity<Tkey> where Tkey : notnull
    {
        Tkey Id { get; set; }
    }
}