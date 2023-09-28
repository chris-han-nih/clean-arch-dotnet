using MediatR;
using Todo.Application.DTOs;

namespace Todo.Application.Features.Todo.Requests.Queries;

public class GetTodoDetailRequest: IRequest<TodoDto>
{
    public long Id { get; set; }
}