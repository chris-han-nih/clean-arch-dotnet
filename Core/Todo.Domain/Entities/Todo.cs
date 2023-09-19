using Todo.Domain.Entities.Common;

namespace Todo.Domain.Entities;

public class Todo: BaseDomainEntity
{
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public int Period { get; set; }
    public DateTime? CompletedAt { get; set; }
}