using AutoMapper;
using MediatR;
using Todo.Application.DTOs;
using Todo.Application.Features.Todo.Requests;
using Todo.Application.Features.Todo.Requests.Queries;
using Todo.Application.Persistence.Contracts;

namespace Todo.Application.Features.Todo.Handlers.Queries;

public class GetTodoListRequestHandler: IRequestHandler<GetTodoListRequest, List<TodoDto>>
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _mapper;

    public GetTodoListRequestHandler(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }
    
    public async Task<List<TodoDto>> Handle(GetTodoListRequest request, CancellationToken cancellationToken)
    {
        var todos = await _todoRepository.GetAllAsync();
        return _mapper.Map<List<TodoDto>>(todos);
    }
}