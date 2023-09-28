using Todo.Application.DTOs.Common;

namespace Todo.Application.DTOs;

public class CreateTodoRequestDto: BaseDto
{
    public string Title { get; set; } = string.Empty;
    public int Period { get; set; }
}