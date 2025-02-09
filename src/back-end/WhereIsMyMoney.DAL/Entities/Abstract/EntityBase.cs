namespace WhereIsMyMoney.DAL.Entities.Abstract;

public abstract record EntityBase
{
    private DateTime _createdAt;
    private Guid _guid;

    public EntityBase()
    {
        CreatedAt = UpdatedAt = DateTime.UtcNow;
    }
    
    public int Id { get; init; }

    public Guid Guid
    {
        get => _guid;
        set => _guid = (value == Guid.Empty) ? Guid.NewGuid() : value;
    }

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value == DateTime.MinValue ? DateTime.Now : value;
    }

    public DateTime UpdatedAt { get; set; }
}