using MediatR;
using Todo.Application.DTOs;

namespace Todo.Application.Features.Todo.Requests;

public class GetTodoListRequest: IRequest<List<TodoDto>>
{
    
}