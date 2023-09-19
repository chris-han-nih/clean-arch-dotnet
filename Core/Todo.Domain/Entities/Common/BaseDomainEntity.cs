namespace Todo.Domain.Entities.Common;

public abstract class BaseDomainEntity
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
}