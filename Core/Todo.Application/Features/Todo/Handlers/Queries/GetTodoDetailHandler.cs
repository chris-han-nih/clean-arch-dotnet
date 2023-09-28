using AutoMapper;
using MediatR;
using Todo.Application.DTOs;
using Todo.Application.Features.Todo.Requests.Queries;
using Todo.Application.Persistence.Contracts;

namespace Todo.Application.Features.Todo.Handlers.Queries;

public class GetTodoDetailHandler: IRequestHandler<GetTodoDetailRequest, TodoDto>
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _mapper;

    public GetTodoDetailHandler(ITodoRepository repository, IMapper mapper)
    {
        _todoRepository = repository;
        _mapper = mapper;
    }
    
    public async Task<TodoDto> Handle(GetTodoDetailRequest request, CancellationToken cancellationToken)
    {
        var todo = await  _todoRepository.GetByIdAsync(request.Id);
        return _mapper.Map<TodoDto>(todo);
    }
}
