using MediatR;
using Todo.Application.DTOs;

namespace Todo.Application.Features.Todo.Requests.Queries;

public class GetTodoListRequest: IRequest<List<TodoDto>>
{
    
}