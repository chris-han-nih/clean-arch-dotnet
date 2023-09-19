using Todo.Application.DTOs.Common;

namespace Todo.Application.DTOs;

public class TodoDto: BaseDto
{
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public int Period { get; set; }
    public DateTime? CompletedAt { get; set; } 
}