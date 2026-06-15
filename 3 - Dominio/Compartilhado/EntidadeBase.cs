public abstract class EntidadeBase<T>
{
    public Guid Id { get; set; }

    public EntidadeBase()
    {
        Id = Guid.NewGuid();
    }
}